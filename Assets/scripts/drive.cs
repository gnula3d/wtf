using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class drive : NetworkBehaviour {
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;


	
	void Update () {

		float translation = CrossPlatformInputManager.GetAxis ("Vertical") * speed;
		float roltation = CrossPlatformInputManager.GetAxis ("Horizontal") * rotationSpeed;

		translation *= Time.deltaTime;
		roltation *= Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotationSpeed, 0);

	}
}
