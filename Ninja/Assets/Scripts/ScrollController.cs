using UnityEngine;
using System.Collections;

public class ScrollController : MonoBehaviour {

	public GameObject EventHandlerObj;
	private EventHandler eventScript;

	public GameObject NR_Obj;
	private NinjasRemaining NR_Script;

	void Awake () {
		// event handler game object
		eventScript = EventHandlerObj.GetComponent<EventHandler>(); 
		NR_Script = NR_Obj.GetComponent<NinjasRemaining> ();
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "ninja" && !eventScript.goNextLevel) {
			GetComponent<AudioSource>().Play();
			coll.collider.isTrigger = true;
			eventScript.ninjasSafe = eventScript.ninjasSafe + 1;
			NR_Script.checkNinjasAlive(eventScript.ninjasSafe);
		}


	}

}
