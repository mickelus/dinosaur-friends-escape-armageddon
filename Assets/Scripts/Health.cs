using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int health = 100;
	public bool dead;

	void FixedUpdate () {
		if(health <= 0){
			dead = true;
			health = 0;
		}
	}
}