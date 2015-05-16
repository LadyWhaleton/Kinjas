using UnityEngine;
using System.Collections;

public class rotateShuriken : MonoBehaviour {

	public float rotateSpeed;
	public float shurikenSpeed;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (shurikenSpeed, 0));
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate ( Vector3.forward * Time.deltaTime * -rotateSpeed);
		Destroy (this.gameObject, 5);
	}

	void OnCollisionEnter2D(){
		Destroy(this.gameObject);
	}	
}
