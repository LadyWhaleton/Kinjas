using UnityEngine;
using System.Collections;

public class SmartTurretController : MonoBehaviour {

	// this is which Ninja the turret is gonna rotate towards
	Vector3 targetDirection;
	float targetAngle;
	public Transform target;
	public float rotationSpeed ; 
	private Quaternion target_rotation;

	// Use this for initialization
	void Start () {
		target = null;
	}
	
	// Update is called once per frame
	void Update () {

		if (target ) {
			// why does our object rotate only when the code is placed outside of the if-statement??
			Debug.Log ("Smart Turret found a Ninja!");
			LockOnPlayer (Time.deltaTime);
		} 
		else {
			idleRotate();
		}
	}
	void LockOnPlayer (float time)
	{
		targetDirection = target.position - transform.position;
		targetAngle = Mathf.Atan2 (targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
		target_rotation = Quaternion.AngleAxis (targetAngle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, target_rotation, time * .75f);
	}

	void idleRotate(){
		transform.Rotate (Vector3.forward * Time.deltaTime * rotationSpeed, Space.World);

		if (transform.rotation.eulerAngles.z > 359 || transform.rotation.eulerAngles.z < 180){
			Debug.Log ("sdfs");
			rotationSpeed = -rotationSpeed;
		}
	}
}
