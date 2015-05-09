using UnityEngine;
using System.Collections;

public class RangeChecker : SmartTurretController {

	void OnTriggerEnter2D (Collider2D col){
		if (target == null && col.gameObject.tag == "ninja") {
			target = col.transform;
			Debug.Log ("Ninja in range");
		}
	}

	void OnTriggerExit2D (Collider2D col){
		target = null;
		Debug.Log ("Ninja out of range.");
	}
}
