using System;
using System.Collections.Generic;

namespace ArchitectureSample
{
    public class StateMachine
    {
        private readonly Dictionary<Type, IState> _statesMap = new();

        private IState _current;


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