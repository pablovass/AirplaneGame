using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class WeatherChange : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(GetWeather());
    }

    IEnumerator GetWeather()
    {
        UnityWebRequest www = UnityWebRequest.Get("api.openweathermap.org/data/2.5/weather?q=bogota&appid=9fc8072b0267bce57438774724d0f689");
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
        }
    }
}
