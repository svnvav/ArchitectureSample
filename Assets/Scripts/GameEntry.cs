using System;
using UnityEngine;

namespace ArchitectureSample
{
    public class GameEntry : MonoBehaviour
    {
        private Game _game;

        private void Awake()
        {
            _game = new Game();
            _game.StateMachine.ChangeState<BootstrapState>();
            
            DontDestroyOnLoad(this);
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

