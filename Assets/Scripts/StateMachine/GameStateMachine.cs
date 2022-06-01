using System;
using System.Collections.Generic;

namespace ArchitectureSample
{
    public class GameStateMachine
    {
        private readonly Dictionary<Type, IState> _statesMap;

        private IState _current;

        public GameStateMachine()
        {
            _statesMap = new Dictionary<Type, IState>()
            {
                {typeof(BootstrapState), new BootstrapState(this)}
            };
        }

        public void RegisterState<TState>(TState state) where TState : IState
        {
            _statesMap.Add(typeof(TState), state);
        }

        public void ChangeState<TState>() where TState : IState
        {
            _current.Exit();

            _current = _statesMap[typeof(TState)];
            _current.Enter();
        }
    }
}