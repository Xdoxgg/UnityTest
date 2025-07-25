using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    private float x_dir = 0f;
    private Vector2 rot;
    public float mouse_sens = 3;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnView(InputAction.CallbackContext context)
    {
        rot = context.ReadValue<Vector2>();
    }

    void Update()
    {
        x_dir = Mathf.Clamp(x_dir, -90, 90);
        x_dir -= rot.y*mouse_sens*Time.deltaTime;
        transform.localRotation = Quaternion.Euler(x_dir, 0f, 0f);
        player.Rotate(Vector3.up * rot.x*mouse_sens*Time.deltaTime);
    }
}
