using UnityEngine;
using System.Collections;

public class NinjaAnimation : MonoBehaviour {

	// my properties
	private Animator anim;
	private SpriteRenderer renderer;

	private bool isDead;

	// parent properties
	private NinjaController parentScript;
	
	void Awake (){
		renderer = GetComponent<SpriteRenderer> ();

		if (renderer.enabled)
			renderer.enabled = false;


		anim = GetComponent<Animator> ();


		// get parent information
		GameObject parentObject = transform.parent.gameObject;
		parentScript = parentObject.GetComponent<NinjaController> ();
	

	}
	
	public void playDeathAnimation(){;
		showAnimation ();
		GetComponent<AudioSource> ().Play ();
		anim.SetBool ("DeathState", true);
	}
	

	void showAnimation(){
		renderer.enabled = true;
	}

	void hideAnimation(){
		renderer.enabled = false;
	}

	public void Die()
	{
		parentScript.Die ();
	}
}
