using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCloud : MonoBehaviour {

    public int numOfPoints;
    public float zoneSize;

    Transform[] points;
    GameObject mainPoint;

	
	void Start () {
        mainPoint = SpawnRandomPoints.SpawnRandomPoint(zoneSize, false);
        mainPoint.transform.localScale *= 4;
        mainPoint.GetComponent<Renderer>().material.color = Color.green;
        points = SpawnRandomPoints.SpawnRandomPointCloud(numOfPoints, zoneSize, transform, false);
        if(ReturnNearestPoint() != null)
        {
            GameObject nearestPoint = ReturnNearestPoint().gameObject;
            nearestPoint.GetComponent<Renderer>().material.color = Color.red;
        }
        
	}

    //this function returns the transform in "points" that is closest to "mainPoint"
    Transform ReturnNearestPoint()
    {
        return null; // temp
    }
	
	
}
