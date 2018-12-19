using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour {

    public GameObject focus;
    public BPMFinder audioObj;
    private bool swapping;
    private Vector3 start;
    private Vector3 end;
    private float barFlip = 48;

	// Use this for initialization
	void Start () {
        swapping = false;
        start = this.transform.position;
        end = start * -1;

    }
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(focus.transform);
        if(swapping == true )
        {
            //transform.position = Vector3.Lerp(transform.position, start, Time.deltaTime * 2.0f);
            this.transform.RotateAround(Vector3.zero, Vector3.up, -20 * Time.deltaTime);
        }
        else
        {
            this.transform.RotateAround(Vector3.zero, Vector3.up, -20 * Time.deltaTime);
        }

        print(swapping);
    }

    void transport(Vector3 loc)
    {
        //this.transform.position = loc;
        this.transform.position = Vector3.Lerp(transform.position, loc, Time.deltaTime * 2.0f);
    }

    private void LateUpdate()
    {
        this.transform.LookAt(focus.transform);
        float count = audioObj.getBarCounter();

        if (count % barFlip == 0)
        {
            if (swapping == true)
            {
                swapping = false;
                transport(start);
            }
            else
            {
                swapping = true;
                transport(end);
            }
        }
    }
}
