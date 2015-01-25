using UnityEngine;
using System.Collections;

public class LevelComplete : MonoBehaviour {

	public GameObject char1;
	public GameObject char2;
	public string nextLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector2.Distance (char1.transform.position, transform.position) < 2.0f &&
			Vector2.Distance (char2.transform.position, transform.position) < 2.0f) {
			FadeOut();
			WaitForSeconds(2);
			Application.LoadLevel (nextLevel);
		}
	}

	void FadeOut() {

	}
}
