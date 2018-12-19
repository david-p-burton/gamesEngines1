using System.Collections;
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
	void Update () {
        for (int i = 0; i < emittors.Length; i++)
        {
            //emittors[i];
            //InvokeRepeating("DoEmit",1.0f, 3.0f);
        }
        //1 + (AudioAnalyzer.bands[i] *

        //InvokeRepeating("DoEmit", 1.0f, 0);

        for (int i = 0; i < emittors.Length; i++)
        {
            var emitSys = emittors[i].GetComponent<ParticleSystem>();
            emitSys.Emit(Mathf.RoundToInt(1 + band[i] * scale));
        }
    }
}
