namespace InteractionSystem.Data
{
    public interface IInteractionData
    {
        public bool TryAddService<T>(T service);

        public bool TryRemoveService<T>();

        public bool TryGetService<T>(out T service);
    }
}
