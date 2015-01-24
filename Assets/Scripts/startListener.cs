using UnityEngine;
using System.Collections;

public class startListener : MonoBehaviour {

	public Canvas startCanvas;
	public Canvas characterSelectCanvas;

	void Start() {
		characterSelectCanvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.JoystickButton9)) {
			startCanvas.enabled = false;
			characterSelectCanvas.enabled = true;
		}
	}
}
