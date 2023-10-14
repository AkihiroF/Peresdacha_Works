using UnityEngine;

namespace Command
{
    public class SpawnPrefabCommand : ICommand
    {
        private GameObject _prefab;

        public SpawnPrefabCommand(GameObject prefab)
        {
            this._prefab = prefab;
        }

        public void Invoke(Vector2 position)
        {
            Object.Instantiate(_prefab, position, Quaternion.identity);
        }
    }
}