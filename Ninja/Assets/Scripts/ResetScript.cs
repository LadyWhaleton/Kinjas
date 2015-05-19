using UnityEngine;
using System.Collections;

public class ResetScript : MonoBehaviour {

	private string[] konamiCode;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("r"))
			//print ("reset");
			Application.LoadLevel (Application.loadedLevelName);
		else if (Input.GetKey ("q")) {
			Application.LoadLevel ("SimpleMainMenu");
		}
	
	}
}
