namespace ClosableUISystem.Implementations.MB.Implementations
{
    public class MBGameObjectClosableUI : AMBClosableUI
    {
        public override void Open()
        {
            gameObject.SetActive(true);
        }

        public override void Close()
        {
            gameObject.SetActive(false);
        }
    }
}