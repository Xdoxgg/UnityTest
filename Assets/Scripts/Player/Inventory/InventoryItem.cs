using Interactive;
using TMPro;
using UnityEngine;

namespace Player.Inventory
{
    public class InventoryItem : MonoBehaviour
    {
        private InteractiveObject _interactiveObject;
        private bool _isStacable;
        private TMP_Text _textCount;
        private int _count;

        public InteractiveObject CurrentInteractiveObject
        {
            get => _interactiveObject;
            set => _interactiveObject = value;
        }

        public bool IsStacable
        {
            get => _isStacable;
            set => _isStacable = value;
        }

        public int Count
        {
            get => _count;
            set => _count = value;
        }

        public TMP_Text CountText
        {
            get => _textCount;
            set => _textCount = value;
        }
        
    }
}