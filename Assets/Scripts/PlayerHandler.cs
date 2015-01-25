using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnitySampleAssets._2D;

public class PlayerHandler : MonoBehaviour {

	public GameObject trex;
	public GameObject raptor;
	
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
		//print (players.Count);
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
