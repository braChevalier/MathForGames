using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiApproximation : MonoBehaviour {

    float radius = 4;
    public Square square;
    public Circle circle;
    Transform[] points;
    int numberOfPoints = 5000;

	
	void Start () {
        square.Initialize(radius * 2);
        circle.Initialize(radius);
        points = SpawnRandomPoints.SpawnRandomPointCloud(numberOfPoints, radius * 2, transform, true);
        Debug.Log("Approximation of Pi: " + ApproximatePi());
	}
	
    //this function returns a pi approximation by using the objects in "points", and considering the circle of radius 4, and the square of size 8
	float ApproximatePi()
    {
        return 0; // temp
    }
}
