using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

    

public class LevelManager : MonoBehaviour {

    public int FullHealth = 3;
    private int CurHealth ;

    public static LevelManager Instance { get; private set; }

    public TimeSpan RunningTime
    {
        get { return DateTime.UtcNow - _startedTime; }

    }

    private DateTime _startedTime;

    void Awake()
    {

        Instance = this;
        CurHealth = FullHealth;

    }
	// Use this for initialization
	void Start () {

        _startedTime = DateTime.UtcNow;
	}
	
 
    // Update is called once per frame
    void Update()
    {


        if (CurHealth >= FullHealth)
        {
            CurHealth = FullHealth;
        }

        if (CurHealth <= 0)
        {
            CurHealth = 0;
            Debug.Log("You are Dead");

        }
    }


    public void TakeDmg(int DamageTaken)
    {

        CurHealth -= DamageTaken;
        Debug.Log("HIT");
    }


    }

