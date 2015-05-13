using UnityEngine;
using System.Collections;

public class NinjaController : MonoBehaviour {

	private float Movespeed = 3;
	private float jumpForce = 300;
	
	private Animator anim;
	private SpriteRenderer NinjaSprite;
	
	private GameObject NinjaAniGO;
	private NinjaAnimation NinjaAniScript;
	
	// character movement inhibition
	private bool isDead = false;
	
	// character movement control
	private bool grounded = false;
	private bool jump = false;
	private float jumpDelay = 0;

	private bool facingRight = true;
	private float h;
	
	
	void Awake(){
		anim = GetComponent<Animator> (); 
		NinjaSprite = GetComponent<SpriteRenderer> ();
		
		// get child information
		Transform childTransform = transform.FindChild ("NinjaAni");
		NinjaAniGO = childTransform.gameObject;
		NinjaAniScript = NinjaAniGO.GetComponent<NinjaAnimation> ();
		
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	public void Die(){
		Destroy (this.gameObject);
	}

	public void setGrounded (bool val){
		grounded = val;
	}

	public void setJump (bool val) {
		jump = val;
	}
	
	void checkFlip (float direction) {
		if ( (direction > 0 && !facingRight) || direction < 0 && facingRight) {
			facingRight = !facingRight;
			flip ();
		}
	}
	
	void flip(){
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
	// Update is called once per frame
	void Update () {

		if (isDead)
			return;

		if (jumpDelay > 0)
			jumpDelay -= Time.deltaTime;

		//Input.GetAxis ("Vertical") > 0
		if(grounded && (Input.GetButtonDown( "Jump" ) || Input.GetKeyDown ("up"))){
			jump = true;
			anim.SetBool ("PressJump", true);
		}

		if (jump && jumpDelay <= 0) {
			jumpDelay = 0.5f;
			GetComponent<AudioSource> ().Play ();
			//anim.SetBool ("PressJump", true);
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, jumpForce));
			//GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpForce);
			
		}
		
		
	}
	
	void FixedUpdate(){
		
		if (isDead) 
			return;
		
		h = Input.GetAxis ("Horizontal");
		
		transform.Translate (Vector3.right * h * Movespeed * Time.deltaTime);
		
		
		if (h > 0) { 
			anim.SetFloat ("speed", 1);
			checkFlip (h);
		}
		
		if (h < 0) {
			anim.SetFloat ("speed", -1);
			checkFlip (h);
			
		}
		
		if (h == 0) {
			anim.SetFloat ("speed", 0);
		}

	}
	
	
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "scroll") {
			anim.SetBool ("touchScroll", true);
			isDead = true;
			GetComponent<BoxCollider2D> ().enabled = false;
			GetComponent<Rigidbody2D> ().isKinematic = true;
		} 

		else if (coll.gameObject.tag == "hazard") {
			Debug.Log ("FATALITY!");
			
			// disable movement and controls, hide Ninja
			isDead = true;
			anim.SetBool ("goDead", true);
			NinjaSprite.enabled = false;
			GetComponent<BoxCollider2D> ().enabled = false;
			GetComponent<Rigidbody2D> ().isKinematic = true;
			
			// show and play death animation
			NinjaAniScript.playDeathAnimation ();
			
		}
	}

}
