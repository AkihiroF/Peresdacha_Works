using Decorator;
using UnityEngine;

public class HotdogDebug : MonoBehaviour
{
    void Start()
    {
        AHotdog classic = new ClassicHotdog();
        Debug.Log($"{classic.GetName()} — {classic.GetCost()}р.");

        AHotdog classicWithPickles = new PicklesDecorator(classic);
        Debug.Log($"Дополнительная информация:");
        Debug.Log($"{classicWithPickles.GetName()} — {classicWithPickles.GetCost()}р.");

        AHotdog classicWithOnion = new SweetOnionDecorator(classic);
        Debug.Log($"{classicWithOnion.GetName()} — {classicWithOnion.GetCost()}р.");
    }
}