using UnityEngine;
using System.Collections;

public class endScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		Application.LoadLevel ("credits");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
