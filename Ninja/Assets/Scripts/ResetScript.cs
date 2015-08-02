using UnityEngine;
using System.Collections;

public class ResetScript : MonoBehaviour {

	private string[] konamiCode;
	public ScrollController ScrollScript;

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
		} else if (Input.GetKey ("p")) {
			Application.LoadLevel("test_level_advanced");
		}
	
	}
}
