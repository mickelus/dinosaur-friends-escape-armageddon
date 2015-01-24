using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowMultiplePlayers : MonoBehaviour {

	public List<Transform> positionArray;
	private float minx, maxx, miny, maxy;
	private float maxdistancex, maxdistancey;

	public levelStart levelStart;

	public float cameraZoom = 1.0f;

	// Use this for initialization
	void Start () {
		positionArray = levelStart.players;
	}
	
	// Update is called once per frame
	void Update () {
		float x = 0f, y = 0f, z = 0f;
		print (positionArray.Count);
		if (positionArray.Count > 0) {

			minx = positionArray [0].position.x;
			maxx = positionArray [0].position.x;
			miny = positionArray [0].position.y;
			maxy = positionArray [0].position.y;

			foreach (Transform t in positionArray) {

					x += t.position.x;
					y += t.position.y;
					z += t.position.z;

					if (minx > t.position.x) {
							minx = t.position.x;
					}
					if (maxx < t.position.x) {
							maxx = t.position.x;
					}
					if (miny > t.position.y) {
							miny = t.position.y;
					}
					if (maxy < t.position.y) {
							maxy = t.position.y;
					}

			}
			x /= positionArray.Count;
			y /= positionArray.Count;
			z /= positionArray.Count;

			maxdistancex = Mathf.Abs (minx) + Mathf.Abs (maxx);
			maxdistancey = Mathf.Abs (miny) + Mathf.Abs (maxy);

			transform.position = new Vector3 (x, y, -10);
			Camera.main.orthographicSize = Mathf.Lerp (Camera.main.orthographicSize, 7 + (Vector2.Distance (new Vector2(minx, miny), new Vector2(maxx, maxy)) / cameraZoom), Time.deltaTime);
		}
	}
}
