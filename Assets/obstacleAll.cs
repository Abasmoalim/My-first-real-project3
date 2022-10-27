using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacleAll : MonoBehaviour


{
    


    
    // Start is called before the first frame update
    void Start()
    {
    public Transform startPosition;
    public Transform player;
    }

    vprivate void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            Player.position = startPos.position;
        }
    }

   
}



