using System;
using UnityEngine;

namespace ArchitectureSample
{
    public class GameEntry : MonoBehaviour
    {
        private StateMachine _gameStateMachine;

        private void Awake()
        {
            _gameStateMachine = new StateMachine();
        }

        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}

