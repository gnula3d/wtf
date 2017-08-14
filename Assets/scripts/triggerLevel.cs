using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class triggerLevel : MonoBehaviour {
	public string level;

	// Use this for initialization
	public void OnTriggerEnter(Collider other) {


		SceneManager.LoadScene ("");

	}

}
