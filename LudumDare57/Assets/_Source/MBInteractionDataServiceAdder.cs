using DecoyInventorySystem;
using DecoyInventorySystem.Implementations.MB;
using InteractionSystem.Data.Implementations.MB.Implementations;
using OxygenTankSystem;
using OxygenTankSystem.Implementations.MB;
using UnityEngine;

public class MBInteractionDataServiceAdder : MonoBehaviour
{
    [SerializeField] private MBInteractionData interactionData;

    [Header("Interaction Services")]
    [SerializeField] private AudioSource interactionAudioSource;
    [SerializeField] private AMBOxygenTank oxygenTank;
    [SerializeField] private AMBDecoyInventory decoyInventory;

    private void Start()
    {
        interactionData.TryAddService(interactionAudioSource);
        interactionData.TryAddService(oxygenTank as IOxygenTank);
        interactionData.TryAddService(decoyInventory as IDecoyInventory);
    }
}
