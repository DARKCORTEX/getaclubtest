using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    public TMP_Dropdown iaLeveldd;
    public GameObject[] karts;
    public Slider[] selectedKartStatSliders;

    //en estas propiedades se cambian los Stats del Player
    
    // Start is called before the first frame update
    void Start()
    {
        ShowSelectedKart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnIaLevelChange()
    {
        GameManager.instance.iaLevelSelected = (GameManager.iaLevels)iaLeveldd.value;
    }
    
    public void SelectKartLeftBtn()
    {
        GameManager.instance.selectedKartID--;
        if(GameManager.instance.selectedKartID < 0)
        {
            GameManager.instance.selectedKartID = karts.Length-1;
        }
        ShowSelectedKart();
    }

    public void SelectKartRightBtn()
    {
        GameManager.instance.selectedKartID++;
        if(GameManager.instance.selectedKartID > karts.Length-1)
        {
            GameManager.instance.selectedKartID = 0;
        }
        ShowSelectedKart();
    }

    public void ShowSelectedKart()
    {
        foreach(GameObject go in karts)
        {
           go.SetActive(false);
        }
        
        karts[GameManager.instance.selectedKartID].SetActive(true);
        
        selectedKartStatSliders[0].value = GameManager.instance.kartsStats[GameManager.instance.selectedKartID].Acceleration;
        selectedKartStatSliders[1].value = GameManager.instance.kartsStats[GameManager.instance.selectedKartID].TopSpeed;
        selectedKartStatSliders[2].value = GameManager.instance.kartsStats[GameManager.instance.selectedKartID].Steer;
        selectedKartStatSliders[3].value = GameManager.instance.kartsStats[GameManager.instance.selectedKartID].Braking;
    }
}
