using Interactive;
using UnityEngine;

namespace Player.Inventory
{
    public class InventorySlot : MonoBehaviour
    {
        private InventoryItem _inventoryItem;

        public bool IsEmpty => _inventoryItem == null;

        public InventoryItem Item
        {
            get => _inventoryItem;
            set => _inventoryItem = value;
        }
    }
}