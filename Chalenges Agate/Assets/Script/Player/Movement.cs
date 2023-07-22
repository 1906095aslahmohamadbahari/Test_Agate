using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float move = 5f;
    [SerializeField] GameObject ControllKeyboard;
    [SerializeField] GameObject ControllMouse;

    Vector2 moveInput;
    Rigidbody2D myRigidbody2D;
    InputAction inputAction;

    private void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        MoveSpeed();
    }

    private void MoveSpeed()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * move, moveInput.y * move);
        myRigidbody2D.velocity = playerVelocity;
    }

    void OnMoveKeyboard(InputValue value)
    {
        if (ControllKeyboard != null)
        {
            moveInput = value.Get<Vector2>();
        }
    }

    void OnMoveMouse(InputValue value)
    {
        if (ControllMouse != null)
        {
            moveInput = value.Get<Vector2>();
        }
    }
}