using UnityEngine;
using System.Collections;

public class SmartTurretController : MonoBehaviour {
	// this is which Ninja the turret is gonna rotate towards
	Vector3 targetDirection;
	float targetAngle;
	public Transform target;

	// Use this for initialization
	void Start () {
		target = null;
	}
	
	// Update is called once per frame
	void Update () {

		if (target ) {
			// why does our object rotate only when the code is placed outside of the if-statement??
			Debug.Log ("Smart Turret found a Ninja!");
			LockOnPlayer ();
		} 
		else {

			transform.Rotate (Vector3.forward * Time.deltaTime * 10, Space.World);
		}
	}
	void LockOnPlayer ()
	{
		targetDirection = target.position - transform.position;
		targetAngle = Mathf.Atan2 (targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (targetAngle, Vector3.forward);
	}
}
