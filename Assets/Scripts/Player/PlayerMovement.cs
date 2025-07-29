using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController _controller;
    //private PlayerInput _playerInput;
    private Vector2 moveInput;
    private Vector3 _dir;
    private Vector3 _velocity;
    [SerializeField]
    private int _speed = 5;
    [SerializeField]
    private int _jumpH = 5;
    [SerializeField]
    private int throwForce = 15;
    private int _gravity = -12;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        //Debug.Log($"Move Input: {moveInput}");
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed && _controller.isGrounded)
        {
            _velocity.y = _jumpH;
        }
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        _controller.Move(_dir * 2 *_speed * Time.deltaTime);
    }

    private void Update()
    {
        if (_controller.isGrounded && _velocity.y < 0)
        {
            _velocity.y = -6;
        }
       
        _dir = moveInput.y * transform.forward + moveInput.x * transform.right;
        _velocity.y += _gravity * Time.deltaTime;
        _controller.Move(_dir * _speed * Time.deltaTime);
        _controller.Move(_velocity * Time.deltaTime);
       
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit != null && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(transform.forward * throwForce, ForceMode.Force);
        }
    }
}
