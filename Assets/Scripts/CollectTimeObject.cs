using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTimeObject : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeCollect;
    public AudioClip soundCollect;
    public GameObject render;
    public TextMesh text;
    public float destroyTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollect()
    {
        TimeManager.OnAdjustTime(timeCollect);
        AudioUtility.CreateSFX(soundCollect, transform.position, AudioUtility.AudioGroups.Pickup, 0f);
        text.text = "+ " + timeCollect.ToString() + " sec";
        render.SetActive(false);
        text.gameObject.SetActive(true);
        Invoke("DestroyObject",destroyTime);
    }
    
    public void EnemyCollect()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            OnCollect();
        }
    }

    public void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
