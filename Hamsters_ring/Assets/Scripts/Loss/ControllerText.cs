using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControllerText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCounter;
    
    void Update()
    {
        _textCounter.text = PlayerController._counterCubes.ToString();
    }
}
