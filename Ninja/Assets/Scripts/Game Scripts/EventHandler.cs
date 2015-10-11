using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour {
	
	public int ninjasSafe = 0;
	private int winNumber = 4;
	public bool goNextLevel = false;

	
	// Update is called once per frame
	void Update () {
		if (ninjasSafe == winNumber) {
			print("Level completed!");
			ninjasSafe = 0;
			goNextLevel = true;
		}
		
		if (goNextLevel){
			if(Application.loadedLevelName == "Basic Test Lvl" || Application.loadedLevelName == "Level1")
				Application.LoadLevel("Level2");
			else if(Application.loadedLevelName == "Level2")
				Application.LoadLevel("level3");
			else if(Application.loadedLevelName == "level3")
				Application.LoadLevel("Level4");
			else if (Application.loadedLevelName == "Level4")
				Application.LoadLevel("TempEndScreen");
			
		}
	}
}
