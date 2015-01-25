using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnitySampleAssets._2D;
using UnitySampleAssets.CrossPlatformInput;

public class PlayerHandler : MonoBehaviour {
	
	public Canvas deathScreen;

	public GameObject trex;
	public GameObject raptor;

	public Transform trexPos;
	public Transform raptorPos;

	private bool gameOver = false;
	public List<GameObject> players;

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetInt ("character1") == 0) {

			trex = (GameObject) GameObject.Find ("Character 1"); //(Resources.Load("Character 1"));

			Platformer2DUserControl control = trex.GetComponent<Platformer2DUserControl>();
			configureControls(control, 1);
			players.Add(trex);
		}
		if (PlayerPrefs.GetInt ("character1") == 1) {
			raptor = (GameObject) GameObject.Find ("Character 2");

			Platformer2DUserControl control = raptor.GetComponent<Platformer2DUserControl>();
			configureControls(control, 1);
			players.Add(raptor);
		}
		if (PlayerPrefs.GetInt ("character2") >= 0) {
			trex = (GameObject) GameObject.Find ("Character 1");

			Platformer2DUserControl control = trex.GetComponent<Platformer2DUserControl>();
			configureControls(control, 2);
			players.Add(trex);
		}
		if (PlayerPrefs.GetInt ("character2") >= 2) {
			raptor = (GameObject) GameObject.Find ("Character 2");

			Platformer2DUserControl control = raptor.GetComponent<Platformer2DUserControl>();
			configureControls(control, 2);
			players.Add(raptor);
		}
	}

	void configureControls(Platformer2DUserControl control, int player) {
		control.playerControlHorizontal = "Player " + player + " Horizontal";
		control.playerControlVertical = "Player " + player + " Vertical";
		control.playerControlJump = "Player " + player + " Jump";
		//control.playerControlUse = "Player " + player + " Horizontal";
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject player in players) {
			if (player.GetComponent<Health> ().dead) {
				endGame ();
				return;
			}
		}
	}

	void endGame() {
		if (!gameOver) {
			gameOver = true;
			Canvas canvas = (Canvas)Instantiate (deathScreen, new Vector3 (0, 0), transform.rotation);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			other.GetComponentInParent<Health>().health = 0;
		}
	}
}
