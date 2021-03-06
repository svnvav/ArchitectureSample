namespace ArchitectureSample
{
    public class Game
    {
        private readonly GameStateMachine _stateMachine;

        public GameStateMachine StateMachine => _stateMachine;

        public Game()
        {
            _stateMachine = new GameStateMachine();
        }
    }
}