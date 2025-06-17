using ClosableUISystem.Implementations.MB;
using InteractionSystem;
using InteractionSystem.Data;
using System;
using UnityEngine;

namespace CollectionSystem
{
    public class MBCollectableObject : MonoBehaviour, IInteractable
    {
        [SerializeField] private AMBClosableUI interactionIndicator;

        public bool IsCollected {  get; private set; }

        public event Action OnCollected;

        public void ShowInteraction()
        {
            interactionIndicator.Open();
        }

        public void HideInteraction()
        {
            interactionIndicator.Close();
        }

        public void Interact(IInteractionData interactionData)
        {
            if (IsCollected)
                return;

            IsCollected = true;
            gameObject.SetActive(false);
            OnCollected?.Invoke();
        }
    }
}