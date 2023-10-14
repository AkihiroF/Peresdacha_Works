namespace Decorator
{
    public class ClassicHotdog : AHotdog
    {
        public ClassicHotdog() : base("Классический")
        {
        }

        public override int GetCost()
        {
            return 210;
        }
    }
}