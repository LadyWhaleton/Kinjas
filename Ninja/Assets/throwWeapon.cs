using UnityEngine;
using System.Collections;

public class throwWeapon : MonoBehaviour {

	public GameObject shuriken;
	GameObject star;

	// Use this for initialization
	void Start () {
		gameObject.SetActive(true);
	}
	
	void toss(){
		Instantiate (shuriken, transform.position, transform.rotation);
	}
	// Update is called once per frame
	void Update () {

		if( Input.GetKeyDown("v")){
			print( "fire");
			GetComponent<AudioSource> ().Play ();
			toss();
		
		}
	}

}