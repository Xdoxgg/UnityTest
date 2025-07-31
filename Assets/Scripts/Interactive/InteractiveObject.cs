using System;
using UnityEngine;
using UnityEngine.Events;

namespace Interactive
{
    public class InteractiveObject : MonoBehaviour, IInteractive
    {
        private Action _action; // == void delegate(void)
        [SerializeField] private string _description;
        [SerializeField] private GameObject _currentGameObject;
        private bool _isInventoried;
        [SerializeField] private string _name;


        public InteractiveObject(Action action, string description)
        {
            _description = description;
            _action = action;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public bool IsInventoried
        {
            get => _isInventoried;
            set => _isInventoried = value;
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