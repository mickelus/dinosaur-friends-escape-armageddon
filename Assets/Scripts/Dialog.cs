using UnityEngine;
using System.Collections;

public class Dialog : MonoBehaviour {

	public GameObject[] players;
	public GameObject dialogToShow;
	public bool show;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		show = false;

		foreach (GameObject child in players)
		{
	
			float distance = Vector2.Distance (transform.position, child.transform.position);

			if(distance < 2.0f) {
				show = true;
			}
			dialogToShow.SetActive(show);
		}
	}
}
