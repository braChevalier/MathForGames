using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

    Vector3 startPoint = new Vector3(3, 4, 0);
    Vector3 endPoint = new Vector3(11, -4, 2);
    float pointSpacing = .2f;

    GameObject pointPrefab;

	void Start () {
        pointPrefab = Resources.Load<GameObject>("Prefabs/Point");
        SpawnPointsInLine();
	}
	
    //this function spawns a line of points, spaced by "pointSpacing", that extends from "startPoint" to "endPoint"
	void SpawnPointsInLine()
    {
        
    }
	
}
