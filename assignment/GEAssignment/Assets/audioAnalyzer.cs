using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Audio;

/*
     * 20-60 - Subbase
     * 60-250 - Bass
     * 250-500 - Low midrange
     * 500 - 2Khz - Midrange
     * 2Khz - 4Khz - Upper midrange
     * 4Khz - 6Khz - Presence
     * 6Khz - 20Khz - Brilliance
*/
[RequireComponent(typeof(AudioSource))]
public class audioAnalyzer : MonoBehaviour
{

    public static int frameSize = 512;

    AudioSource audioSource;
    public static float[] spectrum;
    public static float[] bands;

    // Use this for initialization
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        spectrum = new float[frameSize];
        bands = new float[(int)Mathf.Log(frameSize, 2)];

    }

    void GetBands()
    {
        for (int i = 0; i < bands.Length; i++)
        {
            int start = (int)Mathf.Pow(2, i) - 1;
            int width = (int)Mathf.Pow(2, i);
            int end = start + width;
            float average = 0;
            for (int j = start; j < end; j++)
            {
                average += spectrum[i] * (j - 1);
            }
            average /= width;
            bands[i] = average;
        }
        print("This is the bands length; " + bands.Length);
    }



    void Update()
    {
        audioSource.GetSpectrumData(spectrum, 0, FFTWindow.Blackman);

        GetBands();
    }
}
