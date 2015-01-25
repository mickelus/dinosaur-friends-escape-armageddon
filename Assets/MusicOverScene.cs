using UnityEngine;
using System.Collections;

public class MusicOverScene : MonoBehaviour {

	private static MusicOverScene instance = null;
	public static MusicOverScene Instance {
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
