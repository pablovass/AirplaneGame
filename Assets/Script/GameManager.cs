using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    delegate void SimpleMessage();

    private SimpleMessage _simpleMessage;
    // Start is called before the first frame update
    void Start()
    {
        _simpleMessage += SendConsoleMessage;
        _simpleMessage?.Invoke();

    }

    private void SendConsoleMessage()
    {
        Debug.Log("mensaje desde consola");
    }
}
