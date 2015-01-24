using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnitySampleAssets._2D;

public class levelStart : MonoBehaviour {

	public Transform trex;
	public Transform raptor;
	
	public List<Transform> players;

	// Use this for initialization
	void Start () {
		players = new List<Transform> ();

		if (PlayerPrefs.GetInt ("character1") == 0) {
			Transform transform = (Transform)Instantiate(trex, new Vector3(0,10), new Quaternion(0,0,0,0));
			Platformer2DUserControl control = transform.GetComponent<Platformer2DUserControl>();
			configureControls(control, 1);
			players.Add(transform);
		}
		if (PlayerPrefs.GetInt ("character1") == 1) {
			Transform transform = (Transform)Instantiate (raptor, new Vector3(0,10), new Quaternion(0,0,0,0));
			Platformer2DUserControl control = transform.GetComponent<Platformer2DUserControl>();
			configureControls(control, 1);
			players.Add(transform);
		}
		if (PlayerPrefs.GetInt ("character2") >= 0) {
			Transform transform = (Transform)Instantiate (trex, new Vector3(5,10), new Quaternion(0,0,0,0));
			Platformer2DUserControl control = transform.GetComponent<Platformer2DUserControl>();
			configureControls(control, 2);
			players.Add(transform);
		}
		if (PlayerPrefs.GetInt ("character2") >= 2) {
			Transform transform = (Transform)Instantiate (raptor, new Vector3(5,10), new Quaternion(0,0,0,0));
			Platformer2DUserControl control = transform.GetComponent<Platformer2DUserControl>();
			configureControls(control, 2);
			players.Add(transform);
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
