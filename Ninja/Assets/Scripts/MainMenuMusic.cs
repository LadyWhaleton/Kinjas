using UnityEngine;
using System.Collections;

public class MainMenuMusic : MonoBehaviour {

	private static MainMenuMusic instance;

	
	public static MainMenuMusic Instance {
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<MainMenuMusic>();
				if (instance == null) {
					GameObject obj = new GameObject();
					instance = obj.AddComponent<MainMenuMusic>();
				}
			}
			return instance;
		}
		
	}
	
	public void Awake()
	{
		if (Application.loadedLevelName == "SimpleMainMenu" || Application.loadedLevelName == "Tutorial") {
			DontDestroyOnLoad (this.gameObject);
		
			// if there's no GameManager object, create one
			if (instance == null)
				instance = this as MainMenuMusic;
			// if there's an existing GameManager, destroy it
			else 
				Destroy (gameObject);
		} 
	}

	public void Update()
	{
		if (Application.loadedLevelName != "SimpleMainMenu" && Application.loadedLevelName != "Tutorial" && Application.loadedLevelName != "Credits") {
			Destroy (this.gameObject);
		}
	}
}
