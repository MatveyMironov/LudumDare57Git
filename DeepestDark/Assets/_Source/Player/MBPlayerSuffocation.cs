using OxygenConsumerSystem.Implementations.MB;
using UnityEngine;
using UnityEngine.Events;

namespace PlayerSystem
{
    public class MBPlayerSuffocation : MonoBehaviour
    {
        [SerializeField] private AMBOxygenConsumer oxygenConsumer;
        [SerializeField] private AudioSource effectsAudioSource;
        [SerializeField] private AudioClip deathAudioClip;

        public UnityEvent OnDeath;

        private void Start()
        {
            oxygenConsumer.OnSuffocationStarted += DieFromSuffocation;
        }

        private void DieFromSuffocation()
        {
            effectsAudioSource.PlayOneShot(deathAudioClip);

            OnDeath?.Invoke();
        }
    }
}
