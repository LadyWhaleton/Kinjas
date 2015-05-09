using UnityEngine;
using System.Collections;

public class SmartTurretController : MonoBehaviour {

	// this is which Ninja the turret is gonna rotate towards
	protected Transform target;

	// Use this for initialization
	void Start () {
		target = null;
	}
	
	// Update is called once per frame
	void Update () {

		// why does our object rotate only when the code is placed outside of the if-statement??
		if (target) {
			Debug.Log ("Smart Turret found a Ninja!");

			// LockOnPlayer();


		}
	
	}

	void LockOnPlayer ()
	{

		// Delays the turret rotation so it doesn't freak out whenever the player moves
		Quaternion rotation = Quaternion.LookRotation (target.transform.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);

		transform.LookAt (target.transform);


	}
}
