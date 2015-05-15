using UnityEngine;
using System.Collections;

public class targetCollider : MonoBehaviour {
	Transform barrel;
	SmartTurretController SMT;

	void start(){
		barrel = GameObject.FindWithTag ("barrel").transform;
		SMT = barrel.GetComponent< SmartTurretController> ();
	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == "ninja" && SMT) {
			Debug.Log ("Ninja in range");
			SMT.target = col.transform;
		}
	}

	void OnTriggerExit2D (Collider2D col){
		SMT.target = null;
		Debug.Log ("Ninja is out of range");
	}
}
