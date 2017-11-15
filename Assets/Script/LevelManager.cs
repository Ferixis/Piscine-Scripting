using UnityEngine;
using System;



public class LevelManager : MonoBehaviour {

    // Score //

    public GameObject plane;
    public float scoreAdded;
    public float actualScore;

    public static LevelManager Instance { get; private set; }

    public TimeSpan RunningTime
    {
        get { return DateTime.UtcNow - _startedTime; }

    }

    private DateTime _startedTime;

    void Awake()
    {

        Instance = this;
    }
	// Use this for initialization
	void Start () {

        _startedTime = DateTime.UtcNow;
	}
	
<<<<<<< HEAD
 
    // Update is called once per frame
    void Update()
    {
        Score();

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


    private void KillPlayer()
    {

        if (CurHealth <= 0)
        {

            CurHealth = 0;
          
        }

    }

    void Score ()
    {
        PlayerMoves player = plane.GetComponentInParent<PlayerMoves>();
    }
<<<<<<< HEAD

=======
>>>>>>> ce787c4e676f09f0d7c14ab10b883874ff1f7e2d
=======
    //
>>>>>>> c6b9067a029fac0d44a6d7de0aa0a58c654ed826
    }

