using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOfSquares : MonoBehaviour {

    GameObject squarePrefab;

    int gridWidth = 10;
    int gridHeight = 6;

	void Start () {
        squarePrefab = (GameObject)Resources.Load("Prefabs/Square");
        SpawnSquares();
	}
	
    //this function spawns a series of "squarePrefab" objects that are arranged in a "gridWidth" by "gridHeight" grid
	void SpawnSquares()
    {
        
    }
}
