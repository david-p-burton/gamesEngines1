using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTank : MonoBehaviour {

	public float movementSpeed;
	public float rotationalSpeed;
//
//	private Rigidbody rb;

	// Use this for initialization
	void Start () {
//		ROLLING BALL MOVEMENT
//		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		
		var horz = Input.GetAxis("Horizontal") * Time.deltaTime * rotationalSpeed;
		var vert = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

		transform.Rotate(0, horz, 0);
		transform.Translate(0, 0, vert);

//		ROLLING BALL MOVEMENT
//		float moveHorizontal = Input.GetAxis ("Horizontal");
//		float moveVertical = Input.GetAxis ("Vertical");
//
//		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
//
//		rb.AddForce (movement * speed * 10);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
