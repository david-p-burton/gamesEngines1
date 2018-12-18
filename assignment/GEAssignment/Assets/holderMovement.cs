using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holderMovement : MonoBehaviour {

    float x, y, z = 0;
    float timeCounter = 0;
    public float radius;
    public float speed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeCounter += Time.deltaTime * speed;

        x = Mathf.Cos(timeCounter) * radius;
        y = 0;
        z = Mathf.Sin(timeCounter) * radius;

        transform.position = new Vector3(x, y, z);
	}
}
