using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sway : MonoBehaviour {


	public float angle = 20.0f;
	public float freq = 0.5f;
	//should be private
	public float theta;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//local rotation is rotation relative to its parent rather than the world
		transform.localRotation = Quaternion.AngleAxis (
			Mathf.Sin (theta) * angle, Vector3.forward);
		theta += freq * Time.deltaTime * Mathf.PI * 2.0f;


	}
}
