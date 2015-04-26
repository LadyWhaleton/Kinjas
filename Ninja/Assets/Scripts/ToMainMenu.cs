using UnityEngine;
using System.Collections;

// Script for ToMainMenu button

public class ToMainMenu : MonoBehaviour {

	public void GoBack ()
	{
		Application.LoadLevel ("SimpleMainMenu");
	}
}
