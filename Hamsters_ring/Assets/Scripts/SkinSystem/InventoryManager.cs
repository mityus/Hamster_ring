using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

namespace SkinSystem
{
    public class InventoryManager : MonoBehaviour
    {
        public static InventoryManager Instance;
        
        [Header("Data")]
        public InventoryItemData[] itemsData;

        private List<ItemUI> _items = new List<ItemUI>();

        public List<ItemUI> ItemsList => _items;

        private void Awake()
        {
            if (Instance) Destroy(gameObject);
            Instance = this;
        }

        public void ActivateItem(string id)
        {
            foreach (var elem in _items)
            {
                if (elem.Data.id != id) continue;

                elem.Data.isActive = true;
                InventoryManagerUI.Instance.UpdateUI();
                return;
            }
            Debug.Log("Item was not find!");
        }
    }
}
