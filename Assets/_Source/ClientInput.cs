using Command;
using UnityEngine;

public class ClientInput : MonoBehaviour
{
    public CommandInvoker commandInvoker;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            commandInvoker.InvokeCommand("Move", position);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            commandInvoker.InvokeCommand("Spawn", position);
        }
    }
}