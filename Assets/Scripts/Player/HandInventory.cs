using Interactive;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandInventory : MonoBehaviour
{
    public GameObject _currentItem;

    public void OnUseItem()
    {
        if (_currentItem != null)
        {
            _currentItem?.GetComponent<IInteractive>().Interact();
        }
    }
}
