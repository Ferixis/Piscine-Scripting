using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour {

	public float thrust;
	public Rigidbody rb;
    public float maxSpeed;
    public float ForwardAcceleration;
    public float StraffMaxSpeed = 100f;
    public float StraffTime = 0.1f;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();
		
	}

    private float smoothXVelocity;

	// Update is called once per frame
	void FixedUpdate () {

        Vector3 newVelocity = rb.velocity;
         if (rb.velocity.z > maxSpeed)
        {

            newVelocity.z = maxSpeed;
        }

        else
        {

            newVelocity.z += ForwardAcceleration * Time.fixedDeltaTime;
        }

       float targetvelocity = Input.GetAxis("Horizontal") * StraffMaxSpeed;
        newVelocity.x = Mathf.SmoothDamp(newVelocity.x, targetvelocity, ref smoothXVelocity, StraffTime);
        rb.velocity = newVelocity;




		//rb.AddForce(transform.forward * thrust);
		//rb.velocity = (transform.forward * thrust);
	}

    private void LateUpdate()
    {
        Debug.Log(rb.velocity.z);
    }
}