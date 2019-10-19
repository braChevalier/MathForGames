using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannon : MonoBehaviour {

    public float fireForce;
    public Transform firePoint;

    GameObject cannonBallPrefab;

    void Start()
    {
        cannonBallPrefab = Resources.Load<GameObject>("Prefabs/CannonBall");
    }

    void Update()
    {
        ProcessInput();
    }

    void ProcessInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Fire();
    }

    //this function instantiates a cannonball at the position of "firePoint", and then launches 
    //it by adding a force to its rigidbody whose magnitude is equal to "fireForce"
    void Fire()
    {

    }
}
