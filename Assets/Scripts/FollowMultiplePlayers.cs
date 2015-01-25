using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowMultiplePlayers : MonoBehaviour {

	public List<GameObject> playerArray;
	private float minx, maxx, miny, maxy;
	private float maxdistancex, maxdistancey;

	public PlayerHandler playerHandler;

	public float cameraZoom;

	// Use this for initialization
	void Start () {
		playerArray = playerHandler.players;
	}
	
	// Update is called once per frame
	void Update () {
		float x = 0f, y = 0f, z = 0f;

		if (playerArray.Count > 0) {

			minx = playerArray [0].transform.position.x;
			maxx = playerArray [0].transform.position.x;
			miny = playerArray [0].transform.position.y;
			maxy = playerArray [0].transform.position.y;

			foreach (GameObject t in playerArray) {

					x += t.transform.position.x;
				y += t.transform.position.y;
				z += t.transform.position.z;

				if (minx > t.transform.position.x) {
					minx = t.transform.position.x;
					}
				if (maxx < t.transform.position.x) {
					maxx = t.transform.position.x;
					}
				if (miny > t.transform.position.y) {
					miny = t.transform.position.y;
					}
				if (maxy < t.transform.position.y) {
					maxy = t.transform.position.y;
					}

			}
			x /= playerArray.Count;
			y /= playerArray.Count;
			z /= playerArray.Count;

			maxdistancex = Mathf.Abs (minx) + Mathf.Abs (maxx);
			maxdistancey = Mathf.Abs (miny) + Mathf.Abs (maxy);

			transform.position = new Vector3 (x, y, -10);
			Camera.main.orthographicSize = Mathf.Lerp (Camera.main.orthographicSize, 3f + (Vector2.Distance (new Vector2(minx, miny), new Vector2(maxx, maxy)) / cameraZoom), Time.deltaTime);
		}
	}
}
