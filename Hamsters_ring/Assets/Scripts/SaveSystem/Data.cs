using System;
using UnityEngine;

namespace SaveSystem
{
    [Serializable]
    public class GameData
    {
        public Item[] items;
    }

    [Serializable]
    public struct Item
    {
        public string id;
        public bool isActive;
        public bool isUse;
    }
}