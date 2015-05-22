using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public Transform platform;
	public Transform startPlat;
	public Transform endPlat;

	private Vector3 targetPos;
	private float resetTime;
	private float damping;
	private int currState;	// state indicates where platform will move

	void Awake(){
		currState = -1;
		resetTime = 2f;
		damping = .5f;
		platform = transform.FindChild ("Platform");
		startPlat = transform.FindChild ("StartPos");
		endPlat = transform.FindChild ("EndPos");
	}

	// Use this for initialization
	void Start () {
		changeDirection();
	}
	
	// Update is called once per frame
	void Update () {
		platform.position = Vector3.Lerp(platform.position, targetPos, damping * Time.deltaTime);
	}

	void changeDirection()
	{
		switch(currState) {
		case -1:
			currState = 0;
			targetPos = startPlat.position;
			break;
		case 0:
			currState = 1;
			targetPos = endPlat.position;
			break;
		case 1:
			currState = 0;
			targetPos = startPlat.position;
			break;
		default:
			Debug.Log ("Error: Invalid moving platform state!");
			break;
		}

		Invoke ("changeDirection", resetTime);
	}
}
