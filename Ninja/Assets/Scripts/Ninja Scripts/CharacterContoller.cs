using UnityEngine;
using System.Collections;

public class CharacterContoller : MonoBehaviour {

	public float Movespeed;
	public float jumpForce;


	private bool grounded = false;
	private Animator anim;
	private bool jump = false;
	private bool facingRight = true;
	private float h;
	private bool touchedScroll = false;
	private bool disableControl = false;

	void Awake(){
		anim = GetComponent<Animator> ();
	}

	public void Die(){
		Destroy (this.gameObject);
	}

	// Update is called once per frame
	void Update () {

		// GetComponent<Rigidbody2D>().velocity.
		if (!grounded && Mathf.Abs( GetComponent<Rigidbody2D>().velocity.y )<= 0.05f)
		{
			grounded = true;
			anim.SetBool ("PressJump", false);
		}

		if( (Input.GetButtonDown( "Jump" ) || Input.GetAxis ("Vertical") > 0) && grounded  ){
			jump = true;
		}

	}


	void flip(){
		if (!touchedScroll) {
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}

	}

	void FixedUpdate(){
	
		if (!disableControl) {

			h = Input.GetAxis ("Horizontal");
			if (!touchedScroll) {
				transform.Translate (Vector3.right * h * Movespeed * Time.deltaTime);
			}

			if (h > 0) { 
				anim.SetFloat ("speed", 1);
				if (!facingRight) {
					facingRight = true;
					flip ();
				}
			}



			if (h < 0) {
				anim.SetFloat ("speed", -1);

				if (facingRight) {
					facingRight = false;
					flip ();
				}
			}

			if (h == 0) {
				anim.SetFloat ("speed", 0);
			}

			if (jump) {

				GetComponent<AudioSource> ().Play ();
				anim.SetBool ("PressJump", true);
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, jumpForce));
				jump = false;
				grounded = false;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "scroll") {
			anim.SetBool ("touchScroll", true);
			touchedScroll = true;
			GetComponent<Rigidbody2D> ().isKinematic = true;
		} 
		else if (coll.gameObject.tag == "hazard") {
			//anim.SetBool ("death" , true);
			print("collide");
			transform.Rotate(Vector3.forward );
			disableControl = true;
		}


	}
}
