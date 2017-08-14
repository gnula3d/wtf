using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerActive : MonoBehaviour {

	public GameObject panelDoor;
	public GameObject Panel01;
	public GameObject Panel02;
	public GameObject Panel03;
	public GameObject Panel04;


	public void OnTriggerEnter (Collider other)
	{
		panelDoor.SetActive (false);
		Panel01.SetActive (true);
		Panel02.SetActive (true);
		Panel03.SetActive (true);
		Panel04.SetActive (true);

	}

	public void OnTriggerExit (Collider other)
	{
		panelDoor.SetActive (true);
		Panel01.SetActive (false);
		Panel02.SetActive (false);
		Panel03.SetActive (false);
		Panel04.SetActive (false);

	}

}
