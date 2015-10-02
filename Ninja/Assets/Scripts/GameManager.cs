using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private int levelIndex; // index of the current level

	private static GameManager instance;
	public int points;

	public static GameManager Instance {
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<GameManager>();
				if (instance == null) {
					GameObject obj = new GameObject();
					instance = obj.AddComponent<GameManager>();
				}
			}
			return instance;
		}

	}

	public void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
		
		// if there's no GameManager object, create one
		if (instance == null)
			instance = this as GameManager;
		// if there's an existing GameManager, destroy it
		else 
			Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
		points = 0;
		Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("p"))
		{
		    points++;
			print (points);
		}
	}
	
}
