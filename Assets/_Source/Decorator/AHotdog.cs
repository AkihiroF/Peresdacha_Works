using So;

namespace Decorator
{
    public abstract class AHotdog
    {
        protected HotdogSO hotdogSO;
        
        public HotdogSO HotdogSO => hotdogSO;

        public AHotdog(HotdogSO hotdogSO)
        {
            this.hotdogSO = hotdogSO;
        }

        public virtual string GetName()
        {
            return hotdogSO.hotdogName;
        }

        public virtual int GetCost()
        {
            return hotdogSO.cost;
        }

        public virtual int GetWeight()
        {
            return hotdogSO.weight;
        }
    }
}