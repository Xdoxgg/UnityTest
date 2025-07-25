using System;
using UnityEngine;
using UnityEngine.Events;

namespace Interactive.LocationInteractive
{
    public class InteractiveObject : MonoBehaviour, IInteractive
    {
        private Action _action; // == void delegate(void)
        [SerializeField] 
        private string _description;
        [SerializeField] 
        private GameObject _currentGameObject;

        public InteractiveObject(Action action, string description)
        {
            _description = description;
            _action = action;
        }

        public GameObject CurrentGameObject
        {
            get => _currentGameObject;
            set => _currentGameObject = value;
        }

        public Action ObjectAction
        {
            get => _action;
            set => _action = value;
        }

        public string Description
        {
            get => _description;
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