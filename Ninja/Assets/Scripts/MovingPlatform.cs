using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public Transform platform;
	public Transform startPlat;
	public Transform endPlat;

	// platform properties
	private float moveSpeed;

	private Rigidbody2D rb;
	private Transform destination;
	private Vector3 direction; // indicates which way the platform should move

	void Awake(){
		moveSpeed = .5f;
		platform = transform.FindChild ("Platform");
		startPlat = transform.FindChild ("StartPos");
		endPlat = transform.FindChild ("EndPos");
		rb = platform.gameObject.GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		setDestination(startPlat);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//platform.position = Vector3.Lerp(platform.position, targetPos, moveSpeed * Time.deltaTime);
		rb.MovePosition(platform.position + direction * moveSpeed * Time.fixedDeltaTime);

		if (Vector3.Distance (platform.position, destination.position) < moveSpeed * Time.fixedDeltaTime)
			setDestination (destination == startPlat ? endPlat : startPlat); 
	}

	void setDestination (Transform dest) {
		destination = dest;
		direction = (destination.position - platform.position).normalized;

	}

}
