using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainFlow : MonoBehaviour {

    public enum Exercise {PointCloud, PiApproximation, Centroid, AcuteOrObtuse, WhichSideOfTheLine }

    public Exercise exercise;
	
	void Start ()
    {
        SceneManager.LoadScene(exercise.ToString());
	}
	
	
	
}
