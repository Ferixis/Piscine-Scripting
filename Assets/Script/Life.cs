using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Life : MonoBehaviour
{

    public int FullHealth = 3;
    public int CurHealth = 3;

    // Use this for initialization
    void Start()
    {

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


    void OntriggerEnter(Collider other)
    {
        (collision.gameObject.tag = "Obstacles");
        CurHealth = -1;
        Debug.Log("Hit");
    }


}



     
                


