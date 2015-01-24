using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class startBounce : MonoBehaviour {

	public Text text;
	float y;

	// Use this for initialization
	void Start () {
		y = text.rectTransform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = text.rectTransform.position;
		position.y = y + 5 * Mathf.Sin (Time.time);
		text.rectTransform.position = position;
	}
}
