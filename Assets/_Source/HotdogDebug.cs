using Decorator;
using So;
using UnityEngine;

public class HotdogDebug : MonoBehaviour
{
    [SerializeField] private HotdogSO classicSO;
    [SerializeField] private DecoratorSO picklesSO;
    [SerializeField] private DecoratorSO onionSO;

    void Start()
    {
        AHotdog classic = new ClassicHotdog(classicSO);
        Debug.Log($"{classic.GetName()} ({classic.GetWeight()}г) — {classic.GetCost()}р.");

        AHotdog classicWithPickles = new PicklesDecorator(classic, picklesSO);
        Debug.Log($"Дополнительная информация:");
        Debug.Log($"{classicWithPickles.GetName()} ({classicWithPickles.GetWeight()}г) — {classicWithPickles.GetCost()}р.");

        AHotdog classicWithOnion = new SweetOnionDecorator(classic, onionSO);
        Debug.Log($"{classicWithOnion.GetName()} ({classicWithOnion.GetWeight()}г) — {classicWithOnion.GetCost()}р.");
    }
}