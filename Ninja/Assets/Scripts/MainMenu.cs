using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public void Quit()
	{
		Debug.Log ("Quitting game");
		Application.Quit ();
	}

	public void StartGame()
	{
		Application.LoadLevel ("Level1");
	}

	public void Tutorial ()
	{
		Application.LoadLevel ("Tutorial");
	}

	public void Credits ()
	{
		Application.LoadLevel ("Credits");
	}
}
