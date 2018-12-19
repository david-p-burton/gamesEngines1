using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSetUp : MonoBehaviour {

    private Component[] tests;

    // Use this for initialization
    void Start()
    {
        //tests = GetComponentsInChildren<ParticleSystem>();

        var test = GameObject.Find("particleYellowCenter");
        print("after pYC found");
        foreach(ParticleSystem use in tests)
        {
            var main = use.main;
            main.gravityModifier = 10;
            print("hello");
        }

    }
	// Update is called once per frame
	void Update ()
    {
		
	}
}
