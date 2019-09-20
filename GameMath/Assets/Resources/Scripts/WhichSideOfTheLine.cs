using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichSideOfTheLine : MonoBehaviour {

    Transform A;
    Transform B;
    Transform C;

    float sizeOfArea = 8;
    float moveSpeed = 3;


	void Start () {
        A = SpawnRandomPoints.SpawnRandomPoint(sizeOfArea, true).transform;
        B = SpawnRandomPoints.SpawnRandomPoint(sizeOfArea, true).transform;
        C = SpawnRandomPoints.SpawnRandomPoint(sizeOfArea, true).transform;
        A.localScale *= 2;
        B.localScale *= 2;
        C.localScale *= 3;
        LineRenderer rend = GetComponent<LineRenderer>();
        rend.SetPosition(0, 100 * (A.position - B.position) + A.position);
        rend.SetPosition(1, -100 * (A.position - B.position) + A.position);
        C.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
	
	
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(0, 1, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(0, -1, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(-1, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            C.position += moveSpeed * Time.deltaTime * new Vector3(1, 0, 0);

    }

    
}
