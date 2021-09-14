using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  DG.Tweening;
public class Fade : MonoBehaviour
{
   [SerializeField] SpriteRenderer spriteRenderer;

   [ContextMenu("FadeIn")]
   // de ser transparente a ser ocura
   public void FadeIn()
   {
      spriteRenderer.DOFade(1, 2).OnComplete(() => {
         Debug.Log("FadeIn Completo");
      });
   }
   
   //de ser oscura a transparente
   [ContextMenu("FadeOut")]
   public void FadeOut()
   {
      spriteRenderer.DOFade(0, 2).OnComplete(() => StartGame()).OnStart(() => { Debug.Log("FadeIniciado"); });
   }

   private void StartGame()
   {
      Debug.Log("Fade out completo");
   }

   private void Start()
   {
      FadeOut();
    
   }
}
