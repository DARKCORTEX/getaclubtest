using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollect : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Enemy"))
        {
            GameManager.instance.enemyPoints++;
            Destroy(this.gameObject);
        }
    }
}
