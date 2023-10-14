using UnityEngine;

namespace So
{
    [CreateAssetMenu(fileName = "NewHotdog", menuName = "Hotdog/Base")]
    public class HotdogSO : ScriptableObject
    {
        public string hotdogName;
        public int cost;
        public int weight;
    }
}