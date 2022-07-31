using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Enemy : Cubes
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private GameObject _gameObjectBomb;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(_gameObject, _gameObjectBomb.transform.position, Quaternion.identity);
            StartCoroutine("Delay");
        }
    }
    
    private IEnumerator Delay()
    { 
        yield return new WaitForSeconds(0.9f);

        UnityEngine.SceneManagement.SceneManager.LoadScene (1);
    }
}
