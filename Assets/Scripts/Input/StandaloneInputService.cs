using UnityEngine;

namespace ArchitectureSample
{
    public class StandaloneInputService : IInputService
    {
        public Vector2 GetAxis()
        {
            return Vector2.zero;
        }
    }
}