using System;
using UnityEngine;

namespace Enemies
{
    public abstract class AEnemy : MonoBehaviour
    {
        private void Start()
        {
            HideFromScene();
        }

        public abstract void Attack();

        public abstract void Idle();
        
        public void PerformAction(bool isAttacking)
        {
            if (isAttacking)
            {
                Attack();
            }
            else
            {
                Idle();
            }
        }

        public void ShowOnScene()
        {
            gameObject.SetActive(true);
        }

        public void HideFromScene()
        {
            gameObject.SetActive(false);
        }
    }
}