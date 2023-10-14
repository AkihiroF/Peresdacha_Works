using So;

namespace Decorator
{
    public class SweetOnionDecorator : HotdogDecorator
    {
        public SweetOnionDecorator(AHotdog hotdog, DecoratorSO decoratorSO) : base(hotdog, decoratorSO) { }
    }
}