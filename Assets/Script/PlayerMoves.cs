using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {

	public float spdShip;
    public float maxSpd;
    public float straffMaxSpeed;
    public float straffTime = 0f;
    private Rigidbody rbShip;
    private float smoothXVelocity;

	// Use this for initialization
	void Awake () 
	{
		rbShip = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
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

	void LateUpdate () 
	{
		Debug.Log(rbShip.velocity.z);
	}
}


