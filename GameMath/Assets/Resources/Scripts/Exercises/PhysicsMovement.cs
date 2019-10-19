using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour {
    Rigidbody2D rb;
    Collider2D coli;

    LayerMask mask;

    public float movementForce;
    public float jumpForce;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        coli = gameObject.GetComponent<Collider2D>();
        mask = LayerMask.GetMask("Ground");
    }


    void FixedUpdate()
    {
        ProcessInput();
    }

    //this function checks for S, A, D, and Space key presses.
    //when A or D are pressed, MoveLeft() or MoveRight() are called, respectively
    //when Space is pressed, Jump() is called if IsGrounded() returns true
    //when S is pressed, MoveDown() is called if IsGrounded() returns false
    void ProcessInput()
    {
        
    }

    //this function adds force to the left to "rb" with a magnitude of "movementForce"
    void MoveLeft()
    {

    }

    //this function adds force to the right to "rb" with a magnitude of "movementForce"
    void MoveRight()
    {

    }

    //this function adds a downward force to "rb" with a magnitude of "movementForce"
    void MoveDown()
    {

    }

    //this function adds an upward impulse to "rb" with a magnitude of "jumpForce"
    void Jump()
    {

    }

    bool IsGrounded()
    {
        return coli.IsTouchingLayers(mask.value);
    }



}
