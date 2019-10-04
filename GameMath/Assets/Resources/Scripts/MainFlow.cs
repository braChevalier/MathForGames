using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainFlow : MonoBehaviour {

    public enum Exercise {PointCloud, PiApproximation, Centroid, AcuteOrObtuse, WhichSideOfTheLine, CameraMovement2D, LerpingOverTime, GridOfSquares, Sphere, Line, SineWave,  Rotation1, Rotation2, Rotation3, DelayedAutoAim, BasicPerlinNoise, AdvancedPerlinNoise, MontyHallSimulation, Jumping, Bowling, Shooting }

    public Exercise exercise;
	
	void Start ()
    {
        SceneManager.LoadScene(exercise.ToString());
	}
	
	
	
}
