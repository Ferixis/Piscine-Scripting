using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {

    // Moves //
	public float spdShip;
    public float maxSpd;
    public float straffMaxSpeed;
    public float straffTime = 0f;
    private Rigidbody rbShip;
    private float smoothXVelocity;

    // Shoot //
    public GameObject projectileToShoot;


    void Awake () 
	{
		rbShip = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () 
	{
        Vector3 newVelocity = rbShip.velocity;
        if(rbShip.velocity.z > maxSpd)
        {
            newVelocity.z = maxSpd;
        }

        else
        {
            newVelocity.z += spdShip * Time.deltaTime;
        }

        float targetVelocity = Input.GetAxis("Horizontal") * straffMaxSpeed;
        newVelocity.x = Mathf.SmoothDamp(newVelocity.x, targetVelocity, ref smoothXVelocity, Time.deltaTime);
        rbShip.velocity = newVelocity;
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Shoot();
        }
    }

    void LateUpdate () 
	{
		Debug.Log(rbShip.velocity.z);
	}

    void Shoot ()
    {
        Instantiate(projectileToShoot);
        projectileToShoot.GetComponent<Rigidbody>().velocity = projectileToShoot.transform.forward * 100;
    }
}


