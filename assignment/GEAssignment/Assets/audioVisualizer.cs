//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class audioVisualizer : MonoBehaviour
//{

//    float radius = 110;
//    List<GameObject> cubes = new List<GameObject>();
//    public float scale = 50;

//    // Use this for initialization
//    void Start()
//    {
//        float theta = (Mathf.PI * 2) / (float)audioAnalyzer.bands.Length;

//        for (int i = 0; i < audioAnalyzer.frameSize; i++)
//        {
//            Vector3 p = new Vector3(Mathf.Sin(theta * i) * radius
//                                    , 0
//                                    , Mathf.Cos(theta * i) * radius
//                                   );
//            p = transform.TransformPoint(p);
//            Quaternion q = Quaternion.AngleAxis(theta * i * Mathf.Rad2Deg
//                                                , Vector3.up
//                                               );
//            q = transform.rotation * q;
//            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
//            cube.transform.SetPositionAndRotation(p, q);
//            cube.transform.parent = this.transform;
//            cubes.Add(cube);
//        }

//    }

//    // Update is called once per frame
//    void Update()
//    {

//        for (int i = 0; i < cubes.Count; i++)
//        {
//            print(i);
//            Vector3 ls = cubes[i].transform.localScale;
//            ls.y = 1 + (audioAnalyzer.bands[i] * scale);
//            cubes[i].transform.localScale = ls;
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioVisualizer : MonoBehaviour
{
    public float scale = 10;
    List<GameObject> elements = new List<GameObject>();
    // Use this for initialization
    void Start()
    {
        CreateVisualisers();

    }

    public float radius = 10;

    void CreateVisualisers()
    {
        float theta = (Mathf.PI * 2.0f) / (float)audioAnalyzer.frameSize;
        for (int i = 0; i < audioAnalyzer.frameSize; i++)
        {
            Vector3 p = new Vector3(
                Mathf.Sin(theta * i) * radius
                , 0
                , Mathf.Cos(theta * i) * radius
                );
            p = transform.TransformPoint(p);
            Quaternion q = Quaternion.AngleAxis(theta * i * Mathf.Rad2Deg, Vector3.up);
            q = transform.rotation * q;

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.SetPositionAndRotation(p, q);
            cube.transform.parent = this.transform;
            cube.GetComponent<Renderer>().material.color = Color.Lerp(Color.red, Color.blue, Mathf.PingPong(Time.time, 1));
            elements.Add(cube);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            Vector3 ls = elements[i].transform.localScale;
            ls.y = Mathf.Lerp(ls.y, (audioAnalyzer.bands[i] * scale), Time.deltaTime * 3.0f);
            elements[i].transform.localScale = ls;
        }
    }
}