using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedAutoAim : MonoBehaviour {

    public Transform target;
    public float rotationSpeed = 90;

    void Update()
    {
        Rotate();
    }

    //This function calls RotateClockwise and RotateCounterClockwise depending upon which way this transform needs to rotate to point at the mouse cursor
    void Rotate()
    {
        
    }

    //this function should rotate this transform clockwise by "rotationSpeed" degrees scaled by dt
    void RotateClockwise()
    {

    }

    //this function should rotate this transform counter-clockwise by "rotationSpeed" degrees scaled by dt
    void RotateCounterClockwise()
    {

    }
}
