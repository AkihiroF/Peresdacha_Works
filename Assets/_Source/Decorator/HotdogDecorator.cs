namespace Decorator
{
    public class HotdogDecorator : AHotdog
    {
        protected AHotdog hotdog;

        public HotdogDecorator(AHotdog hotdog) : base(hotdog.GetName())
        {
            this.hotdog = hotdog;
        }

        public override string GetName()
        {
            return hotdog.GetName();
        }

        public override int GetCost()
        {
            return hotdog.GetCost();
        }
    }
}