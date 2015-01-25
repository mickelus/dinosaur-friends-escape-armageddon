using UnityEngine;
using System.Collections;
using UnitySampleAssets.CrossPlatformInput;

public class startListener : MonoBehaviour {

	public Canvas startCanvas;
	public Canvas characterSelectCanvas;

	void Start() {
		characterSelectCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown ("Player Start")) {
			startCanvas.enabled = false;
			characterSelectCanvas.enabled = true;
		}
	}
}
