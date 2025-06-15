namespace PerceptionSystem
{
    public interface IPerciever
    {
        public void StartPercieving(AMBPercievedObject percievedObject);
        public void StopPercieving(AMBPercievedObject percievedObject);
    }
}
