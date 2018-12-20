using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour {

    public static float[] band;
    private float timeCount = 0;

    // Use this for initialization
    void Start () {
        band = audioAnalyzer.bands;
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        
        Vector3 posC = new Vector3(150, 80, -50);
        Quaternion rotC = Quaternion.AngleAxis(1.5f * Mathf.Rad2Deg, Vector3.up);

        Vector3 posS = posC * -1;
        Quaternion rotS = Quaternion.AngleAxis(1.5f * Mathf.Rad2Deg, Vector3.up);


        cube.transform.localScale = new Vector3(50, 30, 50);
        cube.transform.SetPositionAndRotation(posC, rotC);

        sphere.transform.localScale = new Vector3(30, 30, 30);
        sphere.transform.SetPositionAndRotation(posS, rotS);
    }
	
	// Update is called once per frame
	void Update () {

        timeCount += Time.deltaTime * 100;
        GameObject sphere = GameObject.Find("Sphere");
        GameObject cube = GameObject.Find("Cube");

        Vector3 newPosition = cube.transform.position + cube.transform.position - this.transform.position;
        cube.transform.position = Quaternion.AngleAxis(timeCount, Vector3.forward) * new Vector3(100, 0f);

        sphere.transform.position = newPosition;


    }
}
