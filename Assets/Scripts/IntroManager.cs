using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroManager : MonoBehaviour
{
    public TMP_Dropdown iaLeveldd;

    //en estas propiedades se cambian los Stats del Player
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnIaLevelChange()
    {
        GameManager.instance.iaLevelSelected = (GameManager.iaLevels)iaLeveldd.value;
    }
}
