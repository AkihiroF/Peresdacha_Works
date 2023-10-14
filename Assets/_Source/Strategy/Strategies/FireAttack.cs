using UnityEngine;

namespace Strategy.Strategies
{
    public class FireAttack : IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("Performing fire attack!");
        }
    }
}