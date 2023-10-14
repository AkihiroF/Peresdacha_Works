using System;
using Enemies;
using UnityEngine;

namespace Template
{
    public class EnemySwitcher : MonoBehaviour
    {
        [SerializeField] private AEnemy fireEnemy;
        [SerializeField] private AEnemy iceEnemy;
        [SerializeField] private AEnemy lightEnemy;

        public AEnemy FireEnemy => fireEnemy;
        public AEnemy IceEnemy => iceEnemy;
        public AEnemy LightEnemy => lightEnemy;
        private AEnemy _currentEnemy;

        public void ChangeEnemy(Type enemyType)
        {
            if (_currentEnemy != null)
            {
                _currentEnemy.HideFromScene();
            }

            switch (enemyType)
            {
                case { } t when t == typeof(FireEnemy):
                    _currentEnemy = fireEnemy;
                    break;
                case { } t when t == typeof(IceEnemy):
                    _currentEnemy = iceEnemy;
                    break;
                case { } t when t == typeof(LightEnemy):
                    _currentEnemy = lightEnemy;
                    break;
                default:
                    Debug.LogWarning("Unknown enemy type");
                    break;
            }

            if (_currentEnemy != null)
            {
                _currentEnemy.ShowOnScene();
            }
        }
    }
}