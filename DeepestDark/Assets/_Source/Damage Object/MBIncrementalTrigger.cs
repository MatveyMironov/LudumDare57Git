using System;
using UnityEngine;
using UnityEngine.Events;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.UI;

public class MBIncrementalTrigger : MonoBehaviour
{
    [SerializeField] private LayerMask triggeringLayers;
    [SerializeField] private float triggeringTime;
    [SerializeField] private float calmingTime;

    [SerializeField] private UnityEvent OnTriggered;

    private int _triggeringObjects;
    private float _triggerAmount = 0.0f;

    public bool IsBeingTriggered { get => _triggeringObjects > 0; }
    public float TriggerAmount
    {
        get => _triggerAmount;
        private set
        {
            _triggerAmount = value;

            OnTriggerAmountChanged?.Invoke(_triggerAmount);
        }
    }

    public event Action<float> OnTriggerAmountChanged;

    private void Update()
    {
        if (IsBeingTriggered)
        {
            if (triggeringTime > 0.0f)
                TriggerAmount += Time.deltaTime * 1.0f / triggeringTime;
            else 
                TriggerAmount = 1.0f;

            if (TriggerAmount >= 1.0f)
            {
                TriggerAmount -= 1.0f;

                OnTriggered.Invoke();
            }
        }
        else
        {
            if (calmingTime > 0.0f)
                TriggerAmount -= Time.deltaTime * 1.0f / calmingTime;
            else
                TriggerAmount = 0.0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((triggeringLayers & (1 << other.gameObject.layer)) != 0)
        {
            _triggeringObjects++;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if ((triggeringLayers & (1 << other.gameObject.layer)) != 0)
        {
            if (_triggeringObjects > 0)
                _triggeringObjects--;
        }
    }
}