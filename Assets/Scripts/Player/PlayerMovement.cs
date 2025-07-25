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
    private int _gravity = -12;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        Debug.Log($"Move Input: {moveInput}");
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed && _controller.isGrounded)
        {
            _velocity.y = _jumpH;
        }
    }

    private void Update()
    {
        _velocity.y += _gravity*Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
        _dir = moveInput.y * transform.forward + moveInput.x * transform.right;
        _controller.Move(_dir * _speed * Time.deltaTime);
       
    }
}
