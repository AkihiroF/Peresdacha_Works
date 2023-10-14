using So;

namespace Decorator
{
    public class PicklesDecorator : HotdogDecorator
    {
        protected AHotdog hotdog;
        protected DecoratorSO decoratorSO;

        public PicklesDecorator(AHotdog hotdog, DecoratorSO decoratorSO) : base(hotdog, decoratorSO) { }
        
    }
}