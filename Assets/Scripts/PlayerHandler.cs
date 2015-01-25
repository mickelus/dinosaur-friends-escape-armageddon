using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnitySampleAssets._2D;
using UnitySampleAssets.CrossPlatformInput;

public class PlayerHandler : MonoBehaviour {

	public Transform trex;
	public Transform raptor;

	public Canvas deathScreen;
	
	public List<Transform> players;

	// Use this for initialization
	void Start () {
		players = new List<Transform> ();

		if (PlayerPrefs.GetInt ("character1") == 0) {
			Transform t = (Transform)Instantiate(trex, new Vector3(0,10), transform.rotation);
			Platformer2DUserControl control = t.GetComponent<Platformer2DUserControl>();
			configureControls(control, 1);
			players.Add(t);
		}
		if (PlayerPrefs.GetInt ("character1") == 1) {
			Transform t = (Transform)Instantiate (raptor, new Vector3(0,10), transform.rotation);
			Platformer2DUserControl control = t.GetComponent<Platformer2DUserControl>();
			configureControls(control, 1);
			players.Add(t);
		}
		if (PlayerPrefs.GetInt ("character2") >= 0) {
			Transform t = (Transform)Instantiate (trex, new Vector3(5,10), transform.rotation);
			Platformer2DUserControl control = t.GetComponent<Platformer2DUserControl>();
			configureControls(control, 2);
			players.Add(t);
		}
		if (PlayerPrefs.GetInt ("character2") >= 2) {
			Transform t = (Transform)Instantiate (raptor, new Vector3(5,10), transform.rotation);
			Platformer2DUserControl control = t.GetComponent<Platformer2DUserControl>();
			configureControls(control, 2);
			players.Add(t);
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
		foreach (Transform player in players) {
			if (player.GetComponent<Health> ().dead) {
				endGame ();
				return;
			}
		}
	}

	void endGame() {
		Canvas canvas = (Canvas)Instantiate(deathScreen, new Vector3(0,0), transform.rotation);
	}
}
