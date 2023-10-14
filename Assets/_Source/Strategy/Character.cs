using Strategy.Strategies;

namespace Strategy
{
    public class Character
    {
        private IAttackStrategy _strategy;

        public void SetStrategy(IAttackStrategy strategy)
        {
            _strategy = strategy;
        }

        public void PerformAttack()
        {
            if (_strategy != null)
            {
                _strategy.Attack();
            }
        }
    }
}