using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
  private Animator _animator;
  
  private void Start()
  {
    _animator = GetComponent<Animator>();
  }
  
  private void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.tag == "Food" || other.gameObject.tag == "Bonus")
    {
      _animator.SetBool("Eat", true);

      StartCoroutine("Delay");
    }
  }
  
  private IEnumerator Delay()
  {
    yield return new WaitForSeconds(0.1f);
    
    _animator.SetBool("Eat", false);
  }
}
