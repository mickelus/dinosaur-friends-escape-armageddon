using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public float seconds;

	void Start(){
		DontDestroyOnLoad(gameObject);
	}
	

	// Update is called once per frame
	void FixedUpdate () {
		if(Application.loadedLevel == 0){
			Destroy(gameObject);
		}

		seconds -= Time.fixedDeltaTime;

		if(seconds <= 0){
			seconds = 0;
			GameObject.Find("Character 1").GetComponent<Health>().health = 0;
		}
	}

	void OnGUI(){
		GUI.Label(new Rect(32,Screen.height - 32,100,100), "" + (int)seconds);
	}
}
