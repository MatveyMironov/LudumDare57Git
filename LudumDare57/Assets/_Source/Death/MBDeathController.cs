using GameSystem.GameLoss;
using OxygenConsumerSystem.Implementations.MB;
using UnityEngine;

namespace DeathSystem
{
    public class MBDeathController : MonoBehaviour
    {
        [SerializeField] private AMBOxygenConsumer oxygenConsumer;
        [SerializeField] private GameLossController gameLossController;

        private void Start()
        {
            oxygenConsumer.OnSuffocationStarted += Die;
        }

        private void Die()
        {
            gameLossController.LoseGame();

            gameObject.SetActive(false);
        }
    }
}
