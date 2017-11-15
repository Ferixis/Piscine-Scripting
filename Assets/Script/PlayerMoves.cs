using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoves : MonoBehaviour {

    // Move //

	public float spdShip;
    public float maxSpd;
    public float straffMaxSpeed;
    public float straffTime = 0f;

    private Rigidbody rbShip;
    private float smoothXVelocity;

    // Shot //

    public GameObject projectileToShoot;
    public float projectileSpd;
    public Transform rightCanonSpawn;
    public Transform leftCanonSpawn;
    public GameObject shot;
    private AudioClip shotSnd; 

    private GameObject projectileRight;
    private GameObject projectileLeft;


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
        AudioSource shotSnd = shot.GetComponent<AudioSource>();
        shotSnd.Play();

        projectileRight = Instantiate(projectileToShoot,rightCanonSpawn.position,rightCanonSpawn.rotation);
        projectileLeft = Instantiate(projectileToShoot, leftCanonSpawn.position, leftCanonSpawn.rotation);

        projectileRight.GetComponent<Rigidbody>().velocity = projectileRight.transform.forward * projectileSpd;
        projectileLeft.GetComponent<Rigidbody>().velocity = projectileLeft.transform.forward * projectileSpd;

        Destroy(projectileRight, 2.0f);
        Destroy(projectileLeft, 2.0f);
    }
}


