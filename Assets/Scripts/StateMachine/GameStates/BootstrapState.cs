namespace ArchitectureSample
{
    public class BootstrapState : IState
    {
        private readonly GameStateMachine _gameStateMachine;

        public BootstrapState(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        public void Enter()
        {
            
        }

        public void Exit()
        {
            
        }

        private void RegisterServices()
        {
            ServiceLocator.InputService = new StandaloneInputService();
        }
    }
}