using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceHamster : MonoBehaviour
{
    [SerializeField] private List<GameObject> _listHamster = new List<GameObject>();

    public void ChoiceHamsterUsual()
    {
        ChangeSprite.isSprite = true;
        ChangeSprite._sprite = _listHamster[0];
    }
}
