using UnityEngine;
using System.Collections;

public class buttonScript : MonoBehaviour {

	public Sprite normal;
	public Sprite pushed;

	public GameObject target;

	public bool targetState = false;
	public bool untoggle = true;

	private int objectsInArea = 0;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.GetComponentInParent<Rigidbody2D> ().mass >= 5) {
			GetComponent<SpriteRenderer> ().sprite = pushed;
			if(target && target.activeSelf != targetState) {
				target.SetActive (targetState);
			}
		}
		objectsInArea++;
	}

	void OnTriggerExit2D(Collider2D other) {

		objectsInArea--;
		if (objectsInArea <= 0 && untoggle) {
			GetComponent<SpriteRenderer> ().sprite = normal;
			if(target)
				target.SetActive (!targetState);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
