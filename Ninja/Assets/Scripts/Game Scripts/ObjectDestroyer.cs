using UnityEngine;
using System.Collections;

public class ObjectDestroyer : MonoBehaviour {

	public int NinjasKilled = 0;

	public GameObject NR_Obj;
	private NinjasRemaining NR_Script;
	
	void Awake()
	{
		NR_Script = NR_Obj.GetComponent<NinjasRemaining> ();
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "ninja") {
			NinjasKilled++;
			NR_Script.checkNinjasDead(NinjasKilled);
		} 

		Destroy (coll.gameObject);
	}
}
