using UnityEngine;
using System.Collections;

public class ObjectDestroyer : MonoBehaviour {

	public int NinjasKilled = 0;

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "ninja") {
			NinjasKilled++;
		} 

		Destroy (coll.gameObject);
	}
}
