using UnityEngine;
using System.Collections;

public class NinjaGroundChecker : MonoBehaviour {

	private NinjaController parentScript;
	private Animator anim;
	
	void Awake() {
		GameObject parentObject = transform.parent.gameObject;
		parentScript = parentObject.GetComponent<NinjaController> ();
		anim = parentObject.GetComponent<Animator> ();
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "ground") {
			anim.SetBool ("PressJump", false);
		}
	}

	void OnTriggerStay2D(Collider2D col) {
		if (col.gameObject.tag == "ground") {
			parentScript.setGrounded(true);
			parentScript.setJump(false);
		}
	}


	void OnTriggerExit2D (Collider2D col){
		if (col.gameObject.tag == "ground") {
			parentScript.setJump (false);
			parentScript.setGrounded (false);
			anim.SetBool ("PressJump", true);
		}

	}

	                     

}
