using UnityEngine;

namespace SkinSystem
{
    [CreateAssetMenu(fileName = "Skin 1", menuName = "ScriptableObjects/InventoryItem", order = 1)]
    public class InventoryItemData : ScriptableObject
    {
        public string id;
        public Sprite avatar;
        public bool isActive = false;
        public bool isUse = false;
    }
}
