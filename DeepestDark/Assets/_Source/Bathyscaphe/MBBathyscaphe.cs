using InteractionSystem;
using InteractionSystem.Data;
using UnityEngine;
using UnityEngine.Events;

namespace BathyscapheSystem
{
    public class MBBathyscaphe : MonoBehaviour, IInteractable
    {
        [SerializeField] private GameObject _interactionIndicator;

        public UnityEvent OnBathyscapheEntered;

        public void ShowInteraction()
        {
            _interactionIndicator.SetActive(true);
        }

        public void HideInteraction()
        {
            _interactionIndicator.SetActive(false);
        }

        public void Interact(IInteractionData interactionData)
        {
            OnBathyscapheEntered?.Invoke();
        }
    }
}
