using UnityEngine;

namespace Command
{
    public interface ICommand
    {
        public void Invoke(Vector2 position);
    }
}