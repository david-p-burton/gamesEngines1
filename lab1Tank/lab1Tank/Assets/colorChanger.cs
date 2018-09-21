using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour {

	public Renderer rend;
	public Shader shader;
	public Texture texture;
	public Color color;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();

		Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f );
		rend.material = new Material (shader);
		rend.material.mainTexture = texture;
		rend.material.color = newColor;
	}
	
	// Update is called once per frame
	void Update () {
		Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f );
		rend.material.color = newColor;
	}
}
