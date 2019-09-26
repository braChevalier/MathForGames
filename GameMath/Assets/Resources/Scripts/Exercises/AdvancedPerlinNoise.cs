using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedPerlinNoise : MonoBehaviour {

    public LineRenderer line;
    public EdgeCollider2D edgeCollider;

    public float xLength = 100;
    public float vertexSpacing = .1f;

    void Start()
    {
        SetLineVertices();
        SetColliderVertices();
    }

    //this function sets up the LineRenderer "line" so that its vertices form a multi-octave perlin noise surface,
    //extending for "xLength", with vertices spaced by "vertexSpacing"
    void SetLineVertices()
    {
        
    }

    //this function sets the vertices of "edgeCollider" equal to the vertices of "line"
    void SetColliderVertices()
    {
        
    }
}
