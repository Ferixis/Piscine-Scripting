using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingBooster : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        PlayerMoves player = other.gameObject.GetComponentInParent<PlayerMoves>();
        player.Boost();
    }

}
