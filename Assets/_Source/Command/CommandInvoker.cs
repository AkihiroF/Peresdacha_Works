using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class CommandInvoker : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform characterTransform;

        private const int _maxCommands = 10;
        private readonly Stack<ICommand> _commandStack = new Stack<ICommand>();
        private readonly Queue<(ICommand command, Vector2 position)> _rightClickCommandQueue = new Queue<(ICommand, Vector2)>();
        private Dictionary<string, ICommand> _commands;

        private void Start()
        {
            _commands = new Dictionary<string, ICommand>
            {
                { "Spawn", new SpawnPrefabCommand(prefab) },
                { "Move", new MoveCharacterCommand(characterTransform) }
            };
        }

        public void InvokeCommand(string commandName, Vector2 position, bool executeImmediately = true)
        {
            if (_commands.ContainsKey(commandName))
            {
                ICommand command = CreateCommand(commandName);

                if (executeImmediately)
                {
                    command.Invoke(position);

                    if (_commandStack.Count >= _maxCommands)
                    {
                        _commandStack.Pop();
                    }

                    _commandStack.Push(command);
                }
                else
                {
                    _rightClickCommandQueue.Enqueue((command, position));
                }
            }
            else
            {
                Debug.LogWarning($"Command {commandName} not found.");
            }
        }

        public void ExecuteRightClickQueue()
        {
            while (_rightClickCommandQueue.Count > 0)
            {
                var (command, position) = _rightClickCommandQueue.Dequeue();
                command.Invoke(position);

                if (_commandStack.Count >= _maxCommands)
                {
                    _commandStack.Pop();
                }

                _commandStack.Push(command);
            }
        }

        private ICommand CreateCommand(string commandName)
        {
            switch (commandName)
            {
                case "Spawn":
                    return new SpawnPrefabCommand(prefab);
                case "Move":
                    return new MoveCharacterCommand(characterTransform);
                default:
                    return null;
            }
        }

        public void Undo()
        {
            if (_commandStack.Count > 0)
            {
                ICommand command = _commandStack.Pop();
                command.Undo();
            }

        }
    }
}