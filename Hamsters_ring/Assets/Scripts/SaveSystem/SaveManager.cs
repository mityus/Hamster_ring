using System;
using System.Collections.Generic;
using System.IO;
using SkinSystem;
using UnityEngine;

namespace SaveSystem
{
    public class SaveManager : MonoBehaviour
    {
        private string SavePath = Application.persistentDataPath;
        private string FileName = "save.data";
        private string FullSavePath => Path.Combine(SavePath, FileName);


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Save();
            }
        }


        public GameData Load()
        {
            string path = @"C:\Users\mityu\AppData\LocalLow\Develop\Humster";

            string data = File.ReadAllText(path);
            GameData gameData = JsonUtility.FromJson<GameData>(data);
            return gameData;
        }

        public void Save()
        {
            List<Item> items = new List<Item>();

            foreach (var item in InventoryManager.Instance.ItemsList)
            {
                Item newItem = new Item
                {
                    id = item.Data.id,
                    isActive = item.Data.isActive,
                    isUse = item.Data.isUse
                };

                items.Add(newItem);
            }

            GameData gameData = new GameData
            {
                items = items.ToArray()
            };

            string jsonData = JsonUtility.ToJson(gameData);
            string path = @"C:\Users\mityu\AppData\LocalLow\Develop\Humster";

            Debug.Log(jsonData);
            File.WriteAllText(path, jsonData);

            Debug.Log("Data saved success!");
        }
    }
}
