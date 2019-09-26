using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement2D : MonoBehaviour {

    public float movementSpeed = 10;
	
	void Update () {
        ProcessInput();
	}

    //This function should check for keys UpArrow, DownArrow, LeftArrow, and RightArrow being pressed,
    //and call MoveUp, MoveDown, MoveLeft, and MoveRight respectively
    void ProcessInput()
    {
        
    }

    //This function should move the transform in the positive y direction by "movementSpeed" units scaled by dt
    void MoveUp()
    {

    }

    //This function should move the transform in the negative y direction by "movementSpeed" units scaled by dt
    void MoveDown()
    {
      
    }

    //This function should move the transform in the negative x direction by "movementSpeed" units scaled by dt
    void MoveLeft()
    {
        
    }

    //This function should move the transform in the positive x direction by "movementSpeed" units scaled by dt
    void MoveRight()
    {
        
    }

}
