using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPMFinder : MonoBehaviour {

    public float bpm;
    private float beatInterval, beatTimer, beatIntervalDiv8, beatTimerDiv8 ;
    public static bool beatFull, beatDiv8;
    public static int beatCountFull, beatCountDiv8;
    public float barCounter;

    void BeatDetection()
    {
        beatFull = false;
        beatInterval = 60 / bpm;
        beatTimer += Time.deltaTime;
        if(beatTimer >= beatInterval)
        {
            beatTimer -= beatInterval;
            beatFull = true;
            beatCountFull++;
            barCounter++;
        }

        beatDiv8 = false;
        beatIntervalDiv8 = beatInterval / 8;
        beatTimerDiv8 += Time.deltaTime;
        if(beatTimerDiv8 >= beatIntervalDiv8)
        {
            beatTimerDiv8 = beatInterval / 8;
            beatDiv8 = true;
            beatCountDiv8++;
        }
    }

	// Use this for initialization
	void Start () {
        barCounter = 0;
	}

    public float getBarCounter()
    {
        return barCounter;
    }

    // Update is called once per frame
    void Update () {
        BeatDetection();

    }
}
