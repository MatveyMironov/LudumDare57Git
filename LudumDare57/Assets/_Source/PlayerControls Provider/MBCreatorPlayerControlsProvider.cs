namespace PlayerControlsProviderSystem
{
    internal class MBCreatorPlayerControlsProvider : AMBPlayerControlsProvider
    {
        private PlayerControls _playerControls;

        public override PlayerControls PlayerControls
        {
            get
            {
                _playerControls ??= new();

                return _playerControls;
            }
        }
    }
}
