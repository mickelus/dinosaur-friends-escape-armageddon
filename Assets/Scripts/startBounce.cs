using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startBounce : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = text.rectTransform.position;
		position.y = 190 + 5 * Mathf.Sin (Time.time);
		text.rectTransform.position = position;
	}
}
