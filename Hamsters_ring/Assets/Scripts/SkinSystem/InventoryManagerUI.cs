using System;
using UnityEngine;

namespace SkinSystem
{
    public class InventoryManagerUI : MonoBehaviour
    {
        public static InventoryManagerUI Instance;
        
        [Header("World object")]
        [SerializeField] private ItemUI itemUI;
        [SerializeField] private Transform layout;

        private void Awake()
        {
            Instance = this;
        }

        private void OnEnable() => Initialize();

        private void OnDisable() => CleanUp();

        private void Initialize()
        {
            foreach (var item in InventoryManager.Instance.itemsData)
            {
                CreateItem(item);
            }
        }

        public void UpdateUI()
        {
            CleanUp();
            Initialize();
        }
        
        private void CreateItem(InventoryItemData itemData)
        {
            ItemUI newItem = Instantiate(itemUI, layout);
            newItem.Initialize(itemData);
            
            /*newItem.button.onClick.AddListener(delegate
            {
            });*/
            
            InventoryManager.Instance.ItemsList.Add(newItem);
        }

        private void CleanUp()
        {
            foreach (var item in InventoryManager.Instance.ItemsList)
            {
                Destroy(item.gameObject);
            }
            
            InventoryManager.Instance.ItemsList.Clear();
        }
    }
}