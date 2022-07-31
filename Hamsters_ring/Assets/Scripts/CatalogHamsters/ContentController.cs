using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentController : MonoBehaviour
{
    public static GameObject _card;
    public static bool isCard = false;

    [SerializeField] private List<GameObject> _listCardHamsters = new List<GameObject>();
    
    private void Update()
    {
        if (isCard)
        {
            for (int i = 0; i < _listCardHamsters.Count; i++)
            {
                if (_card.name == _listCardHamsters[i].name)
                {
                    _listCardHamsters[i].GetComponent<Image>().color = Color.white;
                    _listCardHamsters[i].GetComponent<Button>().enabled = true;
                    _listCardHamsters.Remove(_listCardHamsters[i]);
                }
            }
        }

        isCard = false;
    }
}
