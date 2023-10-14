namespace Decorator
{
    public abstract class AHotdog
    {
        protected string Name;

        protected AHotdog(string name)
        {
            this.Name = name;
        }

        public virtual string GetName()
        {
            return Name;
        }

        public abstract int GetCost();
    }
}