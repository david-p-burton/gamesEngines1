﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particles : MonoBehaviour {

    public float scale = 15;
    public static float[] spec;
    public static float[] band;

    private GameObject[] emittors;


	// Use this for initialization
	void Start () {
        spec = audioAnalyzer.spectrum;
        band = audioAnalyzer.bands;
        emittors = new GameObject[this.transform.childCount];

        for(int i = 0; i <this.transform.childCount; i++)
        {
            emittors[i] = this.transform.GetChild(i).gameObject;
        }
    }

    void DoEmit()
    {
        //var emitParams = new ParticleSystem.EmitParams();
        //system.Emit(emitParams, 1000);
        //system.Play();

        //for (int i = 0; i < emittors.Length; i++)
        //{
        //    var emitSys = emittors[i].GetComponent<ParticleSystem>();
        //    emitSys.Emit(Mathf.RoundToInt(1 + band[i] * scale));
        //}
    }
	
	// Update is called once per frame
	void Update ()
    {
        //1 + (AudioAnalyzer.bands[i] *

        //InvokeRepeating("DoEmit", 1.0f, 0);

        for (int i = 0; i < emittors.Length; i++)
        {
            var emitSys = emittors[i].GetComponent<ParticleSystem>();

            int emissionSize = Mathf.RoundToInt(band[i] * scale);


            if (emittors[i].name == "particleRed" || emittors[i].name == "particleRedCenter")
            {
                if (emissionSize < -0.1)
                {
                    emissionSize *= -1;
                    emissionSize *= 10;
                    emitSys.Emit(emissionSize);
                    print(emissionSize + " This is red " + emittors[i].name);
                }
                else
                {
                    emissionSize *= 10;
                    emitSys.Emit(emissionSize);
                    print(emissionSize + " This is red " + emittors[i].name);
                }
            }
            else if(emissionSize > 2)
            {
                emitSys.Emit(emissionSize);
            }
        }
    }
}
