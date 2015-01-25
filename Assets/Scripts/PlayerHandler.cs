using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnitySampleAssets._2D;

public class PlayerHandler : MonoBehaviour {

	public Transform trex;
	public Transform raptor;
	
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
		print (players.Count);
	}

	void configureControls(Platformer2DUserControl control, int player) {
		control.playerControlHorizontal = "Player " + player + " Horizontal";
		control.playerControlVertical = "Player " + player + " Vertical";
		control.playerControlJump = "Player " + player + " Jump";
		//control.playerControlUse = "Player " + player + " Horizontal";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
