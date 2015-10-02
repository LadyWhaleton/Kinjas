using UnityEngine;
using System.Collections;

public class NinjasRemaining : MonoBehaviour {

	/*
	public GameObject EH_Object; // Event Handler object
	public GameObject OD_Object; // Object Destroyer object
	*/
	public GameObject NinjasIcon1;
	public GameObject NinjasIcon2;
	public GameObject NinjasIcon3;
	public GameObject NinjasIcon4;

	public GameObject NinjasIcon1Dead;
	public GameObject NinjasIcon2Dead;
	public GameObject NinjasIcon3Dead;
	public GameObject NinjasIcon4Dead;

	public int NinjasDead = 0;
	/*
	private EventHandler EH_Script;
	private ObjectDestroyer OD_Script;
	*/

	void Awake () {
		NinjasIcon1Dead.gameObject.SetActive(false);
		NinjasIcon2Dead.gameObject.SetActive(false);
		NinjasIcon3Dead.gameObject.SetActive(false);
		NinjasIcon4Dead.gameObject.SetActive(false);
		/*
		EH_Script = EH_Object.GetComponent<EventHandler>();
		OD_Script = OD_Object.GetComponent<ObjectDestroyer>();
		*/
	}
	
	/*
	// Update is called once per frame
	void Update () {

		checkNinjasAlive (EH_Script.ninjasSafe);
		checkNinjasDead(OD_Script.NinjasKilled);

	}
	*/

	public void checkNinjasAlive(int ninjasSaved)
	{
		if (ninjasSaved == 1)
			NinjasIcon4.gameObject.SetActive (false);
		else if (ninjasSaved == 2)
			NinjasIcon3.gameObject.SetActive (false);
		else if (ninjasSaved == 3)
			NinjasIcon2.gameObject.SetActive (false);
		else if (ninjasSaved == 4)
			NinjasIcon1.gameObject.SetActive (false);
	}

	public void checkNinjasDead(int ninjasDead)
	{
		NinjasDead = ninjasDead;
		if (ninjasDead == 1) {
			NinjasIcon1.gameObject.SetActive (false);
			NinjasIcon1Dead.gameObject.SetActive (true);
		} else if (ninjasDead == 2) {
			NinjasIcon2.gameObject.SetActive (false);
			NinjasIcon2Dead.gameObject.SetActive (true);
		} else if (ninjasDead == 3) {
			NinjasIcon3.gameObject.SetActive (false);
			NinjasIcon3Dead.gameObject.SetActive (true);
		} else if (ninjasDead == 4) {
			NinjasIcon4.gameObject.SetActive (false);
			NinjasIcon4Dead.gameObject.SetActive (true);
		}
	}

}
