using System;
using UnityEngine;

namespace Interactive.LocationInteractive
{
    public class InteractiveObject: MonoBehaviour ,IInteractive
    {
        private Action _action;// == void delegate(void)
        private string _description;

        public Action ObjectAction
        {
            set => _action = value;
        }

        public string Description
        {
            set => _description = value;
        }
        
        public void Interact()
        {
            _action?.Invoke();
        }

        private void OnDestroy()
        {
            _action = null;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}