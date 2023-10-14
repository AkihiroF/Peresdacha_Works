using UnityEngine;

namespace Command
{
    public class SpawnPrefabCommand : ICommand
    {
        private GameObject _prefab;
        private GameObject _spawnedObject;

        public SpawnPrefabCommand(GameObject prefab)
        {
            this._prefab = prefab;
        }

        public void Invoke(Vector2 position)
        {
            _spawnedObject = Object.Instantiate(_prefab, position, Quaternion.identity);
        }
        public void Undo()
        {
            if (_spawnedObject != null)
            {
                Object.Destroy(_spawnedObject);
            }
        }
    }
}