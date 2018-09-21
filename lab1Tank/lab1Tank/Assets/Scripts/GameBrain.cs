using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBrain : MonoBehaviour {

	public Renderer rend;

	// Use this for initialization
	void Start () {
		GameObject target = Resources.Load ("Target") as GameObject;
		rend = GetComponent<Renderer>();

		//columns
		for (int i = 0; i < 10; i++) {
			//rows
			for (int j = 0; j < 5; j++) {
				GameObject use = Instantiate (target);
				use.transform.position = new Vector3 (-1 * i, j * 2, 0);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
