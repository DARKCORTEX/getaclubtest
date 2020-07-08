using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(cam.transform.position);
        gameObject.transform.localEulerAngles += new Vector3(0, 180, 0);
    }
}
