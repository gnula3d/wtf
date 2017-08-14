using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class setupPlayerCar : NetworkBehaviour {
	public float altura;
	public float distancia;


	//[SyncVar]
	//public string pname = "player";

	/*void OnGUI()
	{
		if (isLocalPlayer)
		{
			pname = GUI.TextField (new Rect (25, Screen.height - 40, 100, 30), pname);
			if (GUI.Button (new Rect (130, Screen.height - 40, 80, 30), "Change")) 
			{
				CmdChangeName (pname);
			}
		}
	}

	[Command]
	public void CmdChangeName(string newName)
	{
		pname = newName;
	}*/

	// Use this for initialization
	void Start ()
	{

		if (isLocalPlayer)
		{
			GetComponent<drive> ().enabled = true;

			Camera.main.transform.position = this.transform.position - this.transform.forward * distancia +
			this.transform.up * altura;
			Camera.main.transform.LookAt (this.transform.position);
			Camera.main.transform.parent = this.transform;
			Camera.main.transform.Rotate (-45, 0, 0);
		}



	}

	void Update()
	{
		//if (isLocalPlayer)
			//this.GetComponentInChildren<TextMesh> ().text = pname;
		

	}

}
