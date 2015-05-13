using UnityEngine;
using System.Collections;

public class NinjaHeadChecker : MonoBehaviour {

	private NinjaController parentScript;
	private Animator anim;

	void Awake(){
		GameObject parentObject = transform.parent.gameObject;
		parentScript = parentObject.GetComponent<NinjaController> ();
		anim = parentObject.GetComponent<Animator> ();
	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.gameObject.tag == "ninja"){
			Debug.Log ("There's a Ninja on my head...");
		}

		else if (col.gameObject.tag == "hazard"){
			Debug.Log ("Ouch, something hit me!");
		}
	}

	void OnTriggerExit2D (Collider2D col){

		if (col.gameObject.tag == "ninja") {
			Debug.Log ("No Ninja on my head...");
		}
		
	}
}
