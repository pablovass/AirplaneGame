using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  DG.Tweening;
public class Fade : MonoBehaviour
{
   [SerializeField] private SpriteRenderer _spriteRenderer;

   [ContextMenu("FadeIn")]
   // de ser transparente a ser ocura
   public void FadeIn()
   {
      _spriteRenderer.DOFade(1, 2);
   }
   
   //de ser oscura a transparente
   [ContextMenu("FadeOut")]
   public void FadeOut()
   {
      _spriteRenderer.DOFade(0, 2);
   }

   private void Start()
   {
      FadeOut();
   }
}
