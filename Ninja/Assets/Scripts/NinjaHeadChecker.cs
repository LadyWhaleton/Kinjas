using UnityEngine;
using System.Collections;

public class NinjaHeadChecker : MonoBehaviour {

	private NinjaController parentScript;
	private Animator anim;

	// stuff for other Ninja
	GameObject otherNinja;
	NinjaController otherNinjaScript; 

	void Awake(){
		GameObject parentObject = transform.parent.gameObject;
		parentScript = parentObject.GetComponent<NinjaController> ();
		anim = parentObject.GetComponent<Animator> ();

		otherNinja = null;
		otherNinjaScript = null;
	}

	void OnTriggerEnter2D(Collider2D col) {
	
		if (col.gameObject.tag == "hazard"){
			Debug.Log ("Ouch, something hit me!");
		}
	}

	void OnTriggerStay2D (Collider2D col) {
		if (otherNinja == null && col.gameObject.tag == "ninjaFeet"){
			Debug.Log ("There's a Ninja on my head...");

			otherNinja = col.transform.parent.gameObject;
			otherNinjaScript = otherNinja.GetComponent<NinjaController> ();
			parentScript.setNinjaOnTop (otherNinjaScript);
		}
	}

	void OnTriggerExit2D (Collider2D col){

		if (otherNinja && col.gameObject.tag == "ninjaFeet") {
			Debug.Log ("No Ninja on my head...");

			// set stuff to null because Ninja is no longer on top
			otherNinja = null;
			otherNinjaScript = null;
			parentScript.setNinjaOnTop (null);

			// set jump delay, penalty for allowing a ninja to jump off of you
			// this would be a good time to switch back to idle animation maybe?
			// if we were to add an animation for holding a ninja on top
			parentScript.setJumpDelay (.5f);
		}
		
	}
}
