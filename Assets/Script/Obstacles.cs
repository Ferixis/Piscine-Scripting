using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

    public int Degats = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter(Collision other)
    {

        PlayerMoves player = other.gameObject.GetComponentInParent<PlayerMoves>();
        Debug.Log(player);

        if(player)
        {

            LevelManager.Instance.TakeDmg(Degats);

        }

       
           
    }

    }
