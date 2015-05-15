using UnityEngine;
using System.Collections;

public class targetCollider : MonoBehaviour {
	GameObject barrel;
	public SmartTurretController SMT;

	void start(){
		barrel = GameObject.FindWithTag ("barrel");
		SMT = barrel.GetComponent< SmartTurretController> ();
	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == "ninja" ) {
			Debug.Log ("Ninja in range");
			SMT.target = col.transform;
		}
	}

	void OnTriggerExit2D (Collider2D col){
		SMT.target = null;
		Debug.Log ("Ninja is out of range");
	}
}
