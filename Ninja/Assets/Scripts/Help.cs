using UnityEngine;
using System.Collections;

public class Help : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		this.gameObject.SetActive(false);
	}

	public void HideWindow() {
		this.gameObject.SetActive(false);
	}
	
	public void ShowWindow() {
		// if Window is already showing, but you click the help button... hide window
		if (this.gameObject.active)
			this.gameObject.SetActive (false);
		else
			this.gameObject.SetActive(true);
	}


}
