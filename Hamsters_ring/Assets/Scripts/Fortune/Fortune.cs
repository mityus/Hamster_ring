using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Fortune : MonoBehaviour
{
    private bool isCorutine = true;
    private int totalAngle;
    private int finalAngle;

    [SerializeField] private int section;
    [SerializeField] private int minTime;
    [SerializeField] private int maxTime;
    [SerializeField] private int angleSpeed;
    [SerializeField] private GameObject[] objList;
    
    public List<GameObject> listCard = new List<GameObject>();
    
    private void Start()
    {
        totalAngle = 360 / section;
    }
    
    public void SpinRotation()
    {
        if (PlayerController._counterCubes >= 5 && isCorutine)
        {
            PlayerController._counterCubes = PlayerController._counterCubes - 5;
            StartCoroutine("Spin");
        }
    }

    private IEnumerator Spin()
    {
        isCorutine = false;
        int randTime = Random.Range(minTime, maxTime);
        
        for (int i = 0; i < randTime; i++)
        {
            transform.Rotate(0, 0, totalAngle / angleSpeed);
            yield return new WaitForSeconds(0.01f);
        }
        
        while (Mathf.RoundToInt(transform.eulerAngles.z) % totalAngle != 0)
        {
            transform.Rotate(0, 0, totalAngle / angleSpeed);
            yield return new WaitForSeconds(0.01f);
        }
        
        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);

        for (int i = 0; i < listCard.Count; i++)
        {
            int angle = 45;
            if (angle * i == finalAngle)
            {
                ChangeSprite._sprite = objList[i];
                ContentController._card = listCard[i];
                ChangeSprite.isSprite = true;
                ContentController.isCard = true;
            }
        }
        
        isCorutine = true;
    }
}
