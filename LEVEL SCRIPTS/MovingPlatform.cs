using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.parent = transform;//keeps the player on the platform
    }
    private void OnTriggerExit(Collider other)
    {
        Player.transform.parent = null;//becomes null when player jumps off platform 
    }
}
