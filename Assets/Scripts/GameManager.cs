﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;
    public enum iaLevels
    {
        facil,
        intermedio,
        dificil
    };

    public iaLevels iaLevelSelected;
    public int enemyPoints;

    public ArcadeKart.Stats baseStats = new ArcadeKart.Stats
        {
            TopSpeed            = 10f,
            Acceleration        = 5f,
            AccelerationCurve   = 4f,
            Braking             = 10f,
            ReverseAcceleration = 5f,
            ReverseSpeed        = 5f,
            Steer               = 5f,
            CoastingDrag        = 4f,
            Grip                = .95f,
            AddedGravity        = 1f,
            Suspension          = .2f
        };

    public ArcadeKart.Stats[] kartsStats;
    public int selectedKartID;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }else
        {
            Destroy(this.gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyPoints >= 3)
        {
            enemyPoints = 0;
            TimeManager.OnSetTime(0,true,GameMode.TimeLimit);
        }
    }
}
