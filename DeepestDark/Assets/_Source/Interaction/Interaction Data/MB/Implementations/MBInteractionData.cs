namespace InteractionSystem.Data.Implementations.MB.Implementations
{
    public class MBInteractionData : AMBInteractionData
    {
        private InteractionData _interactionData;

        private InteractionData InteractionData
        {
            get
            {
                _interactionData ??= new();

                return _interactionData;
            }
        }

        public override bool TryAddService<T>(T service)
        {
            return InteractionData.TryAddService(service);
        }

        public override bool TryGetService<T>(out T service)
        {
            return InteractionData.TryGetService(out service);
        }

        public override bool TryRemoveService<T>()
        {
            return InteractionData.TryRemoveService<T>();
        }
    }
}
