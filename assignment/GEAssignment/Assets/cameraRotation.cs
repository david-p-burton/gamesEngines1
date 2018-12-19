using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour {

    public GameObject focus;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(focus.transform);
        this.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
		
	}
}
