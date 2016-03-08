using UnityEngine;
using System.Collections;

public class AjaranAgha : MonoBehaviour {
	public float playerSpeed =5.0f;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		//transform.position = new Vector3 (0,2,0);
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
//		float step = speed * Time.deltaTime;
//		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (new Vector3(0,0,1 * playerSpeed * Time.deltaTime));
		} else if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up);
		} else if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.down);
		} else if (Input.GetKey (KeyCode.S)) {
			transform.Translate (new Vector3(0,0,-1 *playerSpeed *Time.deltaTime));
		} 
		else if (Input.GetKeyDown (KeyCode.Q)) {
			rb.AddForce(new Vector3(0,250,0));
			//transform.Rotate (new Vector3(-1,0,0 *playerSpeed *Time.deltaTime));
		} 
	}
}
