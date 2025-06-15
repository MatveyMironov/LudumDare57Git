using UnityEngine;

namespace ClosableUISystem.Implementations.MB.Implementations
{
    public class MBCompositeClosableUI : AMBClosableUI
    {
        [SerializeField] private AMBClosableUI[] closableUIs = new AMBClosableUI[0];

        public override void Open()
        {
            foreach (var closableUI in closableUIs)
                closableUI.Open();
        }

        public override void Close()
        {
            foreach (var closableUI in closableUIs)
                closableUI.Close();
        }
    }
}
