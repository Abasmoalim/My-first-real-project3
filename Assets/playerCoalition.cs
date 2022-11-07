using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;




public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement1 movement;

    void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Obstacle"))
        {
            movement.enabled = false;
        }
    }
}