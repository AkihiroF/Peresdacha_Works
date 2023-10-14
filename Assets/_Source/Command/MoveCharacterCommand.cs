using UnityEngine;

namespace Command
{
    public class MoveCharacterCommand : ICommand
    {
        private Transform _characterTransform;

        public MoveCharacterCommand(Transform characterTransform)
        {
            this._characterTransform = characterTransform;
        }

        public void Invoke(Vector2 position)
        {
            _characterTransform.position = position;
        }
    }
}