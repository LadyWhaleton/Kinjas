using UnityEngine;
using System.Collections;

public class trampoline : MonoBehaviour {

	public float trampolineForce;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "ninjaFeet") {
			print ("steepped on trampoline");
			col.transform.parent.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, trampolineForce));
		}
	}
}
