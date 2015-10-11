using UnityEngine;
using System.Collections;

public class NinjaAnimation : MonoBehaviour {

	// my properties
	private Animator anim;
	private SpriteRenderer NinjaAniSprite;

	private bool isDead;

	// parent properties
	private NinjaController parentScript;
	
	void Awake (){
		NinjaAniSprite = GetComponent<SpriteRenderer> ();

		if (NinjaAniSprite.enabled)
			NinjaAniSprite.enabled = false;
	
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
		NinjaAniSprite.enabled = true;
	}

	void hideAnimation(){
		NinjaAniSprite.enabled = false;
	}

	public void Die()
	{
		parentScript.Die ();
	}
}
