using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class creditsScript : MonoBehaviour {

	public Canvas canvas;

	// Use this for initialization
	void Start () {
		print ("asdasd");
		Vector3 pos = canvas.transform.position;
		pos.y = Screen.height;
		print (pos.y);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = canvas.transform.position;
		pos.y -= Time.deltaTime*40;
		canvas.transform.position = pos;
	}
}
