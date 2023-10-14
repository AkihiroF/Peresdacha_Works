using UnityEngine;

namespace Strategy.Strategies
{
    public class IceAttack : IAttackStrategy
    {
        public void Attack()
        {
            Debug.Log("Performing ice attack!");
        }
    }
}