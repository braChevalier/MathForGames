using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPerlinNoise : MonoBehaviour {

    public LineRenderer line;

    public float xLength = 100;
    public float vertexSpacing = .1f;


    void Start () {
        
        SetLineVertices();
    }
	
    //this function sets up the LineRenderer "line" so that its vertices form a perlin noise surface,
    //extending for "xLength", with vertices spaced by "vertexSpacing"
    void SetLineVertices()
    {
        
    }
	
	
}
