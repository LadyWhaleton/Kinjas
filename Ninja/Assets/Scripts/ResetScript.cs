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
			Application.LoadLevel ("Level1");
		else if (Input.GetKey ("q")) {
			Debug.Log("Quitting game.");
			Application.Quit ();
		}
	
	}
}
