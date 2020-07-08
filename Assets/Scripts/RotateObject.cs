using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public bool RotX;
    public bool RotY;
    public bool RotZ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(RotX?speed:0,RotY?speed:0,RotZ?speed:0),Space.Self);
    }
}
