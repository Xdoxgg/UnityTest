using Interactive;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    public LayerMask layer;
    [SerializeField]
    private float _distance;
    private RaycastHit _hit;

    public void Interact(InputAction.CallbackContext context)
    {
        if (Physics.Raycast(transform.position, transform.forward, out _hit, _distance, layer))
        {
            GameObject temp = _hit.collider.gameObject;
            if (temp !=null)
            {
                Debug.Log(temp.GetComponent<IInteractive>().GetDescription());
                temp.GetComponent<IInteractive>().Interact();
            }
            else
            {
                Debug.Log("nothing");
            }
        }
    }
}
