using Enemies;
using UnityEngine;

namespace Strategy.Strategies
{
    public class IceAttack : IAttackStrategy
    {
        public AEnemy AssociatedEnemy { get; private set; }

        public IceAttack(AEnemy enemy)
        {
            AssociatedEnemy = enemy;
        }

        public void Attack()
        {
            AssociatedEnemy.PerformAction(true);
        }
    }
}