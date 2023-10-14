namespace Decorator
{
    public class SweetOnionDecorator : HotdogDecorator
    {
        public SweetOnionDecorator(AHotdog hotdog) : base(hotdog) { }

        public override string GetName()
        {
            return base.GetName() + " с сладким луком";
        }

        public override int GetCost()
        {
            return base.GetCost() + 30;
        }
    }
}