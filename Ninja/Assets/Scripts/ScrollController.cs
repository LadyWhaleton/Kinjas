using UnityEngine;
using System.Collections;

public class ScrollController : MonoBehaviour {

	public GameObject EventHandlerObj;
	private EventHandler eventScript;

	void Awake () {
		// event handler game object
		eventScript = EventHandlerObj.GetComponent<EventHandler>(); 
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "ninja" && !eventScript.goNextLevel) {
			GetComponent<AudioSource>().Play();
			coll.collider.isTrigger = true;
			eventScript.ninjasSafe = eventScript.ninjasSafe + 1;
		}


	}

}
