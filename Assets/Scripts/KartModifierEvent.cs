using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class KartModifierEvent : MonoBehaviour
{
    public float speed;
    public float acceleration;
    public float steer;
    public float delay;
    float timeElapse;
    public LayerMask layerMask;
    public bool trampoline;
    public float jumpHigh;
    public float jumpHighPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        var rb = col.attachedRigidbody;
        if(rb) 
        {
            var kart = rb.GetComponent<ArcadeKart>();

            if (kart)
            {
                StartMod(kart);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        var rb = col.attachedRigidbody;
        if(rb) 
        {
            var kart = rb.GetComponent<ArcadeKart>();

            if (kart)
            {
                FinishMod(kart);
            }
        }
    }
    
    public void StartMod(ArcadeKart kart)
    {
        kart.baseStats.Acceleration += acceleration;
        kart.baseStats.TopSpeed += speed;
        kart.baseStats.Steer += steer;
        if(trampoline)
        {
            if(kart.transform.CompareTag("Player"))
            {
                kart.Rigidbody.AddForce(0,jumpHighPlayer,0,ForceMode.Impulse);
            }else
            {
                kart.Rigidbody.AddForce(0,jumpHigh,0,ForceMode.Impulse);
            }   
        }
    }

    public void FinishMod(ArcadeKart kart)
    {

        while(delay < timeElapse)
        {
            timeElapse += Time.deltaTime;
        }

        timeElapse = 0;
        kart.baseStats.Acceleration -= acceleration;
        kart.baseStats.TopSpeed -= speed;
        kart.baseStats.Steer -= steer;
    }
}
