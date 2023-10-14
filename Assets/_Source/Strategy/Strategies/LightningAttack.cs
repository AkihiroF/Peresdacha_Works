using UnityEngine;

namespace Strategy.Strategies
{
    public class LightningAttack : IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("Performing lightning attack!");
        }
    }
}