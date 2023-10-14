namespace Decorator
{
    public class PicklesDecorator : HotdogDecorator
    {
        public PicklesDecorator(AHotdog hotdog) : base(hotdog) { }

        public override string GetName()
        {
            return base.GetName() + " с маринованными огурцами";
        }

        public override int GetCost()
        {
            return base.GetCost() + 50;
        }
    }
}