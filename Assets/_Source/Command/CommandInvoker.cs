using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class CommandInvoker : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform characterTransform;

        private Dictionary<string, ICommand> _commands;

        private void Start()
        {
            _commands = new Dictionary<string, ICommand>
            {
                { "Spawn", new SpawnPrefabCommand(prefab) },
                { "Move", new MoveCharacterCommand(characterTransform) }
            };
        }

        public void InvokeCommand(string commandName, Vector2 position)
        {
            if (_commands.ContainsKey(commandName))
            {
                _commands[commandName].Invoke(position);
            }
            else
            {
                Debug.LogWarning($"Command {commandName} not found.");
            }
        }
    }
}