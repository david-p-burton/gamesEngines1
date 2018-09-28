using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

	public float movementSpeed;
	public float rotationalSpeed;
	public int wayPoints;
	public Transform[] points;
	private int destPoint;
	public float radius;

	// Use this for initialization
	void Start () {
		wayPointGenerator ();
		goToNextPoint ();
	}

	//make waypoints
	void wayPointGenerator ()	{
		float theta = 360 / wayPoints;
		print (theta);


		for (int i = 0; i < wayPoints; i++) {
//			GameObject newPoint = new GameObject();
			GameObject newPoint = Resources.Load ("Target") as GameObject;

			GameObject use = Instantiate (newPoint);

			use.transform.position = new Vector3 (Mathf.Sin(theta * i * Mathf.Deg2Rad) * radius, 0.5f, Mathf.Cos(theta * i  * Mathf.Deg2Rad) * radius);
			print ( Mathf.Cos(theta * i) + radius  +  "  " + Mathf.Sin(theta * i) + radius);
			//gameObject.transform.Translate(1, 1, 1);
		}
	}

	void goToNextPoint() {
		destPoint++;
		if (destPoint > wayPoints) {
			destPoint = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
