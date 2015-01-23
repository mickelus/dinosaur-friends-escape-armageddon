	using UnityEngine;
	using System.Collections;

	public class Movement2D : MonoBehaviour {

	public float Speed = 1.0f;

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		

		}

		void FixedUpdate () 
		{
			Vector2 stickInput = new Vector2 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
			/*
			if (Options.useController == true) {
				if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.A)) {
					stickInput = Vector2.zero;
				} else if (stickInput.magnitude < deadZone) {
					stickInput = Vector2.zero;
				} else {
					stickInput.Normalize ();
					rigidbody2D.velocity = stickInput * Speed * Time.deltaTime;
				}
			}
			*/
		
			//Here is keyboard input - this is working great.
			//else if (Options.useController == false) {

				if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.W)) {
					stickInput = new Vector2 (-1f, 1f);
					stickInput.Normalize ();
					rigidbody2D.velocity = stickInput * Speed * Time.deltaTime;  
				} else if (Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.D)) {
					stickInput = new Vector2 (1f, 1f);
					stickInput.Normalize ();
					rigidbody2D.velocity = stickInput * Speed * Time.deltaTime; 
				} else if (Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.D)) {
					stickInput = new Vector2 (1f, -1f);
					stickInput.Normalize ();
					rigidbody2D.velocity = stickInput * Speed * Time.deltaTime; 
				} else if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.S)) {
					stickInput = new Vector2 (-1f, -1f);
					stickInput.Normalize ();
					rigidbody2D.velocity = stickInput * Speed * Time.deltaTime; 
				} else if (Input.GetKey (KeyCode.W)) {
					stickInput = new Vector2 (0f, 1f);
					stickInput.Normalize ();
					rigidbody2D.velocity = stickInput * Speed * Time.deltaTime; 
				} else if (Input.GetKey (KeyCode.D)) {
					stickInput = new Vector2 (1f, 0f);
					stickInput.Normalize ();
					rigidbody2D.velocity = stickInput * Speed * Time.deltaTime; 
				} else if (Input.GetKey (KeyCode.S)) {
					stickInput = new Vector2 (0f, -1f);
					stickInput.Normalize ();
					rigidbody2D.velocity = stickInput * Speed * Time.deltaTime; 
				} else if (Input.GetKey (KeyCode.A)) {
					stickInput = new Vector2 (-1f, 0f);
					stickInput.Normalize ();
					rigidbody2D.velocity = stickInput * Speed * Time.deltaTime; 
				}
			
		}
	}
