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
<<<<<<< HEAD
			if (checkGround(col)){
				anim.SetBool ("PressJump", false);
=======
		if (checkJumpable(col)){
			anim.SetBool ("PressJump", false);
>>>>>>> master
		}
	}
	void OnTriggerStay2D(Collider2D col) {
		// set flag for grounded
<<<<<<< HEAD
		if (checkGround(col)){
=======
		if (checkJumpable(col)) {
>>>>>>> master
			parentScript.setGrounded(true);
			anim.SetBool ("PressJump", false);
		}
	}
	
	void OnTriggerExit2D (Collider2D col){
		// Set flags for Ninja no longer grounded
<<<<<<< HEAD
		if (checkGround(col)){
=======
		if (checkJumpable(col)) {
>>>>>>> master
			parentScript.setJump (false);
			parentScript.setGrounded (false);
		}

	}

	                     

}
