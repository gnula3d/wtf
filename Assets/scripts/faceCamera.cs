﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceCamera : MonoBehaviour {


	
	// Update is called once per frame
	void Update () 
	{
		this.transform.LookAt (Camera.main.transform.position);
		this.transform.Rotate (new Vector3 (0, 180, 0));
		//this.transform.Rotate (0, 0, 0);

		
	}
}
