using UnityEngine;
using System.Collections;

public class ResetScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("r"))
			//print ("reset");
			Application.LoadLevel (Application.loadedLevelName);
		else if (Input.GetKeyDown ("t"))
			Application.LoadLevel ("Basic Test Lvl");
		else if (Input.GetKey ("q")) {
			Application.Quit ();
		}
	
	}
}
