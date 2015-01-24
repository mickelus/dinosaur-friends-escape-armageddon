using UnityEngine;
using System.Collections;


public class WaterTrigger : MonoBehaviour {

	bool hurt;
	public int hp;
	Transform t;


	void OnTriggerEnter2D(Collider2D other){
		if(other.transform.GetComponent<Health>()){
			StartCoroutine(Hurt(other.transform.GetComponent<Health>()));
			t = other.transform;
			hurt = true;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if(other.transform == t){
			hurt = false;
		}
	}

	IEnumerator Hurt(Health h){
		h.health -= hp;
		yield return new WaitForSeconds (1);
		if(hurt){
			StartCoroutine (Hurt(h));
		}
	}
}