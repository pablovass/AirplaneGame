using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class ShipMovement : MonoBehaviour
{
   public Ease ease;
   private void Start()
   {
      transform.DOMoveX(0,2).SetEase(ease);
   }
}
