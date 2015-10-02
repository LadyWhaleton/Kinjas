using UnityEngine;
using System.Collections;

public class Help : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		this.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void HideWindow() {
		this.gameObject.SetActive(false);
	}
	
	public void ShowWindow() {
		this.gameObject.SetActive(true);
	}


}
