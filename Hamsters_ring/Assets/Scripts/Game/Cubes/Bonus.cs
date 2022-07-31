using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : Cubes
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerController._counterCubes = PlayerController._counterCubes  + Random.Range(5, 10);
            Destroy(cube);
        }
    }
}
