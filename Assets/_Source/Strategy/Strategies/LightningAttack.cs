using Enemies;
using UnityEngine;

namespace Strategy.Strategies
{
    public class LightningAttack : IAttackStrategy
    {
        public AEnemy AssociatedEnemy { get; private set; }

        public LightningAttack(AEnemy enemy)
        {
            AssociatedEnemy = enemy;
        }

        public void Attack()
        {
            AssociatedEnemy.PerformAction(true);
        }
    }
}