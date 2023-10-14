using Enemies;

namespace Strategy.Strategies
{
    public interface IAttackStrategy
    {
        void Attack();
        AEnemy AssociatedEnemy { get; }
    }
}