using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelComplete : MonoBehaviour {

	public GameObject char1;
	public GameObject char2;
	public string nextLevel;
	public float distance;
	public Fader fader;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		if(Vector2.Distance (char1.transform.position, transform.position) < distance &&
			Vector2.Distance (char2.transform.position, transform.position) < distance) {
			fader.sceneStarting = false;
			StartCoroutine(WaitThenLoad());

=======
		if(Vector2.Distance (char1.transform.position, transform.position) < 2.0f &&
			Vector2.Distance (char2.transform.position, transform.position) < 2.0f) {
			FadeOut();
			new WaitForSeconds(2);
			Application.LoadLevel (nextLevel);
>>>>>>> 6019e188be4a92f03c207c25c71298007dfd5372
		}
	}

	IEnumerator WaitThenLoad() {
		yield return new WaitForSeconds(2);
		Application.LoadLevel (nextLevel);
	}

}
