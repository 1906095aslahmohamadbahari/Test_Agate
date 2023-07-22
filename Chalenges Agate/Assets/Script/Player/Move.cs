using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    Rigidbody2D myRigidBody2D;

    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        movementDiretion();
    }

    private void Update()
    {

    }

    void movementDiretion()
    {
        myRigidBody2D.velocity += new Vector2 (moveSpeed, moveSpeed);
    }
}
