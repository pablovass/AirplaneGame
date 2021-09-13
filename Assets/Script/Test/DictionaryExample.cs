using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
   // definimos nuestros nuevo diccionario 
   public Dictionary<string, string> dict = new Dictionary<string, string>();
   public Dictionary<string, PlayerData> playerDict = new Dictionary<string, PlayerData>();

   private void Start()
   {
      dict["avion"] = "Aeronave de ala fija";
      dict["barco"] = "Construccion que flota y navega en el agua";
      dict["mar"] = "Cuerpo de agua";

      dict.TryGetValue("avion", out string value);

      Debug.Log(value);
      foreach (string def in dict.Values)
      {
         Debug.Log(def);
      }

      playerDict["pedroelloco"] = new PlayerData("pedro", 10);
      playerDict["Jmaster"] = new PlayerData("Juan", 30);

      foreach (PlayerData player in playerDict.Values)
      {
        Debug.Log(player.name); 
      }

   }
}

public class PlayerData
   {
      public string name;
      public int score;

      public  PlayerData(string nameP, int score)
      {
         name = nameP;
         score = score;
      }

   }

