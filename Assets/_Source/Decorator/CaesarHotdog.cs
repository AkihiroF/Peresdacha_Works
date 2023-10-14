namespace Decorator
{
    public class CaesarHotdog : AHotdog
    {
        public CaesarHotdog() : base("Цезарь")
        {
        }

        public override int GetCost()
        {
            throw new System.NotImplementedException();
        }
    }
}