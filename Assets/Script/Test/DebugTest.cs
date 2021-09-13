using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("mensajes");
        Debug.LogWarning("mandar warning");
        Debug.LogError("mandar error");
        //te muestra el valor de i en cosola
       // Debug.LogFormat($"<color=blue>{i}</color>");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
