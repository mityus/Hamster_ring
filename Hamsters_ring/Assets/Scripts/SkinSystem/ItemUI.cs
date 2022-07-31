using UnityEngine;
using UnityEngine.UI;

namespace SkinSystem
{
    public class ItemUI : MonoBehaviour
    {
        [SerializeField] private Image avatar;
        [Range(0, 1)] [SerializeField] private float deactivateAlpha = 0.6f;

        public Button button;

        private InventoryItemData _data;

        public InventoryItemData Data => _data;

        public void Initialize(InventoryItemData inventoryItemData)
        {
            avatar.sprite = inventoryItemData.avatar;
            if (!inventoryItemData.isActive) avatar.color = new Color(1, 1, 1, deactivateAlpha);

            _data = inventoryItemData;
        }
    }
}