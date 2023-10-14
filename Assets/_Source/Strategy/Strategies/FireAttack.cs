using Enemies;
using UnityEngine;

namespace Strategy.Strategies
{
    public class FireAttack : IAttackStrategy
    {
        public AEnemy AssociatedEnemy { get; private set; }

        public FireAttack(AEnemy enemy)
        {
            AssociatedEnemy = enemy;
        }

        public void Attack()
        {
            AssociatedEnemy.PerformAction(true);
        }
    }
}