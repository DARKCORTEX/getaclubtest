using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public ArcadeKart playerKart;
    public ArcadeKart enemyKart;
    
    void Start()
    {
        SetIaLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetIaLevel()
    {
        playerKart.baseStats = GameManager.instance.baseStats;

        if(GameManager.instance.iaLevelSelected == GameManager.iaLevels.facil)
        {
            enemyKart.baseStats.TopSpeed = 8;
            enemyKart.baseStats.Acceleration = 2;
        }else if(GameManager.instance.iaLevelSelected == GameManager.iaLevels.intermedio)
        {
            enemyKart.baseStats.TopSpeed = 10;
            enemyKart.baseStats.Acceleration = 5;
        }else if(GameManager.instance.iaLevelSelected == GameManager.iaLevels.dificil)
        {
            
            enemyKart.baseStats.TopSpeed = 12;
            enemyKart.baseStats.Acceleration = 8;
        }
    }

}
