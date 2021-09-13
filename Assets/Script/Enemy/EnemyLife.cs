using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
   
   public GameObject explosion;

   private void OnTriggerEnter2D(Collider2D collision)
   {
      if (collision.CompareTag("Player"))
      {
         GameObject go=Instantiate(explosion);
         go.transform.position = transform.position;
         Destroy(gameObject);
      }
   }
}
