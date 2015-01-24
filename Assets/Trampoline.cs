using UnityEngine;
using System.Collections;

[RequireComponent(typeof (LineRenderer))]
public class Trampoline : MonoBehaviour {

	public Transform[] segments;
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < segments.Length; i++){
			GetComponent<LineRenderer>().SetPosition(i, segments[i].position);
		}
	}
}