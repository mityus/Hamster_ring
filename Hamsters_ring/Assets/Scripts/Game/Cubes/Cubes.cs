using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Accessibility;
using Random = UnityEngine.Random;

public class Cubes : MonoBehaviour
{
    public GameObject _pointDown;
    public GameObject cube;

    private void Update()
    {
        transform.Rotate(0, 0, 0.2f);
        
        transform.position = Vector3.MoveTowards(transform.position, 
            _pointDown.transform.position, 
            3 * Time.deltaTime);
        
        if (cube.transform.position.y == _pointDown.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
