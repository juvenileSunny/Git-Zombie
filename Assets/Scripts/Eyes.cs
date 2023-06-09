﻿using UnityEngine;
using System.Collections;

public class Eyes : MonoBehaviour {

	private Camera eyes;
	private float defaultFOV;
	private float eyeMoveStabilizer = 1.5f;

	// Use this for initialization
	void Start () {
		eyes = GetComponent<Camera> ();
		defaultFOV = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Zoom")) {
			eyes.fieldOfView = defaultFOV / eyeMoveStabilizer;
		} else {
			eyes.fieldOfView = defaultFOV;
		}
	}
}
