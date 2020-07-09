using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public ArcadeKart playerKart;
    public GameObject[] wheelsType;
    public GameObject[] kartType;
    public Material[] matType;
    public ArcadeKart enemyKart;
    
    void Start()
    {
        SetPlayerKart();
        SetIaLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetIaLevel()
    {

        if(GameManager.instance.iaLevelSelected == GameManager.iaLevels.facil)
        {
            enemyKart.baseStats.TopSpeed = 10;
            enemyKart.baseStats.Acceleration = 4;
        }else if(GameManager.instance.iaLevelSelected == GameManager.iaLevels.intermedio)
        {
            enemyKart.baseStats.TopSpeed = 11;
            enemyKart.baseStats.Acceleration = 6;
        }else if(GameManager.instance.iaLevelSelected == GameManager.iaLevels.dificil)
        {
            
            enemyKart.baseStats.TopSpeed = 13;
            enemyKart.baseStats.Acceleration = 9;
        }
    }

    public void SetPlayerKart()
    {
        playerKart.baseStats = GameManager.instance.kartsStats[GameManager.instance.selectedKartID];
        foreach(GameObject go in wheelsType)
        {
            go.SetActive(false);
        }

        foreach(GameObject go in kartType)
        {
            go.SetActive(false);
        }

        if(GameManager.instance.selectedKartID == 0)
        {
            wheelsType[0].SetActive(true);
            kartType[0].SetActive(true);
            kartType[0].transform.GetComponent<SkinnedMeshRenderer>().material = matType[0];
        }else if(GameManager.instance.selectedKartID == 1)
        {
            wheelsType[0].SetActive(true);
            kartType[0].SetActive(true);
            kartType[0].transform.GetComponent<SkinnedMeshRenderer>().material = matType[1];
        }else if(GameManager.instance.selectedKartID == 2)
        {
            wheelsType[0].SetActive(true);
            kartType[0].SetActive(true);
            kartType[0].transform.GetComponent<SkinnedMeshRenderer>().material = matType[2];
        }else if (GameManager.instance.selectedKartID == 3)
        {
            wheelsType[1].SetActive(true);
            kartType[1].SetActive(true);
            kartType[1].transform.GetChild(0).GetComponent<MeshRenderer>().material = matType[3];
        }else if (GameManager.instance.selectedKartID == 4)
        {
            wheelsType[1].SetActive(true);
            kartType[1].SetActive(true);
            kartType[1].transform.GetChild(0).GetComponent<MeshRenderer>().material = matType[4];
        }

    


        //kartType[0].transform.GetChild(0).GetComponent<MeshRenderer>().material = matType[0];


    }

}
