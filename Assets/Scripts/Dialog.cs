using UnityEngine;
using System.Collections;

public class Dialog : MonoBehaviour {

	public GameObject[] players;
	public GameObject dialogToShow;
	public float maxdistance;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		bool show = false;

		foreach (GameObject child in players)
		{
	
			float distance = Vector2.Distance (transform.position, child.transform.position);

			if(distance < maxdistance) {
				show = true;
			}
			dialogToShow.SetActive(show);
		}
	}
}
