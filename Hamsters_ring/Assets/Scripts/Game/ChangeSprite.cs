using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
   public static GameObject _sprite;
   public static bool isSprite = false;

   public List<GameObject> playersList = new List<GameObject>();

   private int countObjList = 0;

   private void Update()
   {
      if (isSprite)
      {
          for (int i = 0; i < playersList.Count; i++)
          {
              Instantiate(_sprite, playersList[i].transform.position, playersList[i].transform.rotation);
              Destroy(playersList[i]);
              countObjList++;
          }
         
          playersList.Clear();

          while (countObjList > 0)
          {
              playersList.Add(_sprite);
              countObjList--;
          }
      }

      isSprite = false;
   }
}
