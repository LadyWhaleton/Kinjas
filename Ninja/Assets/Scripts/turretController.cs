using UnityEngine;
using System.Collections;

public class turretController : MonoBehaviour {

	float a = 10;


	// Update is called once per frame
	void Update () {
	
		transform.Rotate(Vector3.forward * Time.deltaTime *100, Space.World);

	}
}
