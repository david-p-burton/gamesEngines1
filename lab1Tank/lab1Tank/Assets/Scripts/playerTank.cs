using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTank : MonoBehaviour {

	public float movementSpeed;
	public float rotationalSpeed;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	void Start () {
	}

	void FixedUpdate ()
	{
		
		var horz = Input.GetAxis("Horizontal") * Time.deltaTime * rotationalSpeed;
		var vert = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

		transform.Rotate(0, horz, 0);
		transform.Translate (0, 0, vert);
	}

	void Update () {

		if (Input.GetKeyDown(KeyCode.Space))
		{
			rootyTootyPointNShooty();
		}
		
	}

	void rootyTootyPointNShooty()	{

		var bullet = (GameObject)Instantiate (
			             bulletPrefab,
			             bulletSpawn.position,
			             bulletSpawn.rotation);

		bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 10;

		Destroy (bullet, 5.0f);
	}
}
