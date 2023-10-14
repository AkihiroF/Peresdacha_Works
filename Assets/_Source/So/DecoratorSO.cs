using UnityEngine;

namespace So
{
    [CreateAssetMenu(fileName = "NewDecorator", menuName = "Hotdog/Decorator")]
    public class DecoratorSO : ScriptableObject
    {
        public string decoratorName;
        public int cost;
        public int weight;
    }
}