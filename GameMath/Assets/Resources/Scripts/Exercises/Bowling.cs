﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowling : MonoBehaviour {

    Rigidbody2D rb;

    float rightMovementForce = 10;
    float upMovementForce;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        upMovementForce = CalculateForceToHover();
    }

    //this function returns the force necessary for "rb" to counteract gravity
    float CalculateForceToHover()
    {
        return 0; //temp
    }


    void FixedUpdate()
    {
        ForceRight();
        ForceUp();
    }

    void ForceRight()
    {
        rb.AddForce(Vector2.right * rightMovementForce, ForceMode2D.Force);
    }

    //this function applies an upward force equal in magnitude to "upMovementForce"
    void ForceUp()
    {
        
    }


}
