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

		if(Vector2.Distance (char1.transform.position, transform.position) < distance &&
			Vector2.Distance (char2.transform.position, transform.position) < distance) {
			fader.sceneStarting = false;
			StartCoroutine(WaitThenLoad());
			Application.LoadLevel (nextLevel);
		}
	}

	IEnumerator WaitThenLoad() {
		yield return new WaitForSeconds(2);
		Application.LoadLevel (nextLevel);
	}

}
