using UnityEngine;
using System.Collections;
using UnitySampleAssets.CrossPlatformInput;

public class deathScreenScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		print ("update");
		if (CrossPlatformInputManager.GetButtonDown ("Player Start")) {
			print ("Player Start");
			Application.LoadLevel("startScreen");
		}
	}
}
