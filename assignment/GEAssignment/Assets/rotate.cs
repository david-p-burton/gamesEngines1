using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    public float speed = 0;
    public float rotationPM;
    //public Transform start, end;
    private GameObject sphere, cube;

	// Use this for initialization
	void Start () {
        sphere = GameObject.Find("Sphere");
        cube = GameObject.Find("Cube");
    }
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.up * Time.deltaTime * speed);

        //transform.Rotate(0, 6 * rotationPM * Time.deltaTime, 0);

        //sphere.transform.rotation();

        //Quaternion.Lerp(start.rotation, end.rotation, Time.time * speed);
    }
}
