namespace Decorator
{
    public class MeatHotdog : AHotdog
    {
        public MeatHotdog() : base("Мясной")
        {
        }

        public override int GetCost()
        {
            return 250;
        }
    }
}