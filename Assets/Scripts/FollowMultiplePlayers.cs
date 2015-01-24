using UnityEngine;
using System.Collections;

public class FollowMultiplePlayers : MonoBehaviour {

	public Transform[] positionArray;
	private float minx, maxx, miny, maxy;
	private float maxdistancex, maxdistancey;

	public float maxDistance;
	public float cameraZoom = 1.0f;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {

		float x = 0f, y = 0f, z = 0f;

		minx = positionArray[0].position.x;
		maxx = positionArray[0].position.x;
		miny = positionArray[0].position.y;
		maxy = positionArray[0].position.y;

		for(int i = 0; i < positionArray.Length;i++) {

			x += positionArray[i].position.x;
			y += positionArray[i].position.y;
			z += positionArray[i].position.z;

			if(minx > positionArray[i].position.x) {
				minx = positionArray[i].position.x;
			}
			if(maxx < positionArray[i].position.x) {
				maxx = positionArray[i].position.x;
			}
			if(miny > positionArray[i].position.y) {
				miny = positionArray[i].position.y;
			}
			if(maxy < positionArray[i].position.y) {
				maxy = positionArray[i].position.y;
			}

		}
		x /= positionArray.Length;
		y /= positionArray.Length;
		z /= positionArray.Length;

		maxdistancex = Mathf.Abs (minx) + Mathf.Abs (maxx);
		maxdistancey = Mathf.Abs (miny) + Mathf.Abs (maxy);

		transform.position = new Vector3(x, y, -10);
	
		Camera.main.orthographicSize = Mathf.Lerp (Camera.main.orthographicSize, 7 + (Vector2.Distance(positionArray[0].position,positionArray[1].position) / cameraZoom), Time.deltaTime);
		
	}
}
