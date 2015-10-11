using UnityEngine;
using System.Collections;

public class NinjaGroundChecker : MonoBehaviour {

	private NinjaController parentScript;
	private Animator anim;

	bool checkGround(Collider2D col){
		if (col.gameObject.tag == "ground" || col.gameObject.tag == "one_way_platform" || col.gameObject.tag == "ninjaHead") 
			return true;
			
		return false;

	}

	
	void Awake() {
		GameObject parentObject = transform.parent.gameObject;
		parentScript = parentObject.GetComponent<NinjaController> ();
		anim = parentObject.GetComponent<Animator> ();
	}

	bool checkJumpable(Collider2D col){
		if (col.gameObject.tag == "ground" || col.gameObject.tag == "one_way_platform" || col.gameObject.tag == "ninjaHead")	
			return true;
		return false;
	}

	void OnTriggerEnter2D(Collider2D col) {
		// revert Ninja back to idle animation
		if (checkGround(col)){
				anim.SetBool ("PressJump", false);
		}
		if (checkJumpable(col)){
			anim.SetBool ("PressJump", false);
		}
	
		//c
	}
	void OnTriggerStay2D(Collider2D col) {
		// set flag for grounded
		if (checkJumpable(col)) {
			parentScript.setGrounded(true);
			anim.SetBool ("PressJump", false);
		}
	}
	
	void OnTriggerExit2D (Collider2D col){
		// Set flags for Ninja no longer grounded
		if (checkJumpable(col)) {
			parentScript.setJump (false);
			parentScript.setGrounded (false);
		}

	}

	                     

}
