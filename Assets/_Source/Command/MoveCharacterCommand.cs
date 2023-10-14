using UnityEngine;

namespace Command
{
    public class MoveCharacterCommand : ICommand
    {
        private Transform _characterTransform;
        private Vector2 _lastPosition;

        public MoveCharacterCommand(Transform characterTransform)
        {
            this._characterTransform = characterTransform;
        }

        public void Invoke(Vector2 position)
        {
            _lastPosition = _characterTransform.position;
            _characterTransform.position = position;
        }

        public void Undo()
        {
            _characterTransform.position = _lastPosition;
        }
    }
}