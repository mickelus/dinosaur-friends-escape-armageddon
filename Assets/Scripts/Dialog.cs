using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Dialog : MonoBehaviour {

	private List<Transform> players;
	public GameObject dialogToShow;
	public bool show;

	public PlayerHandler playerHandler;

	// Use this for initialization
	void Start () {
		players = playerHandler.players;
	}
	
	// Update is called once per frame
	void Update () {

		show = false;

		foreach (Transform child in players)
		{
	
			float distance = Vector2.Distance (transform.position, child.transform.position);

			if(distance < 2.0f) {
				show = true;
			}
			dialogToShow.SetActive(show);
		}
	}
}
