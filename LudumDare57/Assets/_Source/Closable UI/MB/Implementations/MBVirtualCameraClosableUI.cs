using Cinemachine;
using UnityEngine;

namespace ClosableUISystem.Implementations.MB.Implementations
{
    public class MBVirtualCameraClosableUI : AMBClosableUI
    {
        [SerializeField] private CinemachineVirtualCamera virtualCamera;

        public override void Open()
        {
            virtualCamera.enabled = true;
        }

        public override void Close()
        {
            virtualCamera.enabled = false;
        }
    }
}