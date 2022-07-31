using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using SkinSystem;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCounterCubes;
    
    public static int _counterCubes;
    public static bool changeDirection = true;
    
    void Update()
    {
        _textCounterCubes.text = _counterCubes.ToString();
    }

    public void changePosition()
    {
        if (changeDirection)
        {
            changeDirection = false;
        }
        else
        {
            changeDirection = true;
        }
    }
}
