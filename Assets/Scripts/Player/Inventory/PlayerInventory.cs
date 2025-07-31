using System;
using System.Collections.Generic;
using System.Linq;
using Interactive;
using UnityEngine;

namespace Player.Inventory
{
    public class PlayerInventory : MonoBehaviour
    {
        private List<InventorySlot> _slots;

        private int _maxSize;

        public PlayerInventory()
        {
            MaxSize = 8;
            _slots = new List<InventorySlot>(MaxSize);
            
        }
        
        
        public List<InventorySlot> Slots
        {
            get => _slots;
            set
            {
                if (value.Count <= MaxSize) _slots = value;
                throw new ArgumentException("uncorrected size");
            }
        }

        public int MaxSize
        {
            get => _maxSize;
            set => _maxSize = value;
        }

        public bool AddItem(InventoryItem item)
        {
            foreach (var slot in Slots)
            {
                if (slot.Item == null)
                {
                    slot.Item = item;
                    return true;
                }
            }
            
            return false;
        }

        public InventoryItem RemoveItem(string name)
        {
            
            //ToDo: finish
            return Slots.Find(el => el.Item.CurrentInteractiveObject.Name == name).Item;
        }
    }
}