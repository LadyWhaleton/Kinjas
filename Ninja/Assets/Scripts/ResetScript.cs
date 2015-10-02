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
		} 
		/*
		else if (Input.GetKey ("p")) {
			Application.LoadLevel("test_level_advanced");
		}
		*/
		else if (Input.GetKey ("1") && Application.loadedLevelName != "Level1"){
			Application.LoadLevel("Level1");
		}
		else if (Input.GetKey ("2") && Application.loadedLevelName != "Level2"){
			Application.LoadLevel("Level2");
		}
		else if (Input.GetKey ("3") && Application.loadedLevelName != "level3"){
			Application.LoadLevel("level3");
		}
		else if (Input.GetKey ("4") && Application.loadedLevelName != "Level4"){
			Application.LoadLevel("Level4");
		}
	
	}
}
