using So;

namespace Decorator
{
    public class HotdogDecorator : AHotdog
    {
        protected AHotdog hotdog;
        protected DecoratorSO decoratorSO;

        public HotdogDecorator(AHotdog hotdog, DecoratorSO decoratorSO) : base(hotdog.HotdogSO)
        {
            this.hotdog = hotdog;
            this.decoratorSO = decoratorSO;
        }

        public override string GetName()
        {
            return hotdog.GetName() + " с " + decoratorSO.decoratorName;
        }

        public override int GetCost()
        {
            return hotdog.GetCost() + decoratorSO.cost;
        }

        public override int GetWeight()
        {
            return hotdog.GetWeight() + decoratorSO.weight;
        }
    }
}