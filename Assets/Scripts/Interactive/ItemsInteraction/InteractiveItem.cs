using UnityEngine;

namespace Interactive.ItemsInteraction
{
    public class InteractiveItem:MonoBehaviour, IInteractive
    {
        private string _name;
        private GameObject _currentGameObject;
        
        
        public void Interact()
        {
            
        }

        public string GetDescription()
        {
            return $"Take {_name}";
        }
    }
}