using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public Transform platform;
	public Transform startPos;
	public Transform endPos;

	void Awake(){
		platform = transform.FindChild ("Platform");
		startPos = transform.FindChild ("StartPos");
		endPos = transform.FindChild ("EndPos");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
