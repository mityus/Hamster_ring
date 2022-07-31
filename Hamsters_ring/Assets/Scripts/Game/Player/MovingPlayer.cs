using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    private int _speedMove = 100;
    private void Update()
    {
        if (PlayerController.changeDirection)
        {
            transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, 1f), 
                _speedMove * Time.deltaTime);
        }
        else if (!PlayerController.changeDirection)
        {
            transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0f, 0f, -1f), 
                _speedMove * Time.deltaTime);
        }
    }
}
