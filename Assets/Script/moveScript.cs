﻿using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour {
	public float moveSpeed; 
	public Rigidbody rb;
	public int unit_rotate = 1;
	public int unit_force =10;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	// Update is called once per frame
	void FixedUpdate () {
		//float h = Input.GetAxis ("Horizontal") * moveSpeed;
		if (Input.GetKey (KeyCode.W)) {
		//	Debug.Log (Vector3.forward * unit);
			rb.AddRelativeForce (Vector3.forward * unit_force);
		}
		else if (Input.GetKey (KeyCode.S)) {
		//	Debug.Log(Vector3.forward*unit);
			rb.AddRelativeForce(Vector3.back * unit_force);
		}
		else if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up* unit_rotate);
		} else if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.down *unit_rotate);
		}
	}

}
