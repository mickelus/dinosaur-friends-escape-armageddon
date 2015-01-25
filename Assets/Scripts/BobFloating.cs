using UnityEngine;
using System.Collections;

public class BobFloating : MonoBehaviour {

	public GameObject parentObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float bobValue = 2 + 0.1f * Mathf.Sin (Time.time * 10f);
		transform.position = new Vector3(parentObject.transform.position.x, parentObject.transform.position.y + bobValue, parentObject.transform.position.z);
	}
}
