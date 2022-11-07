
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float forwardForce1 = 500f;
    public float sidewaysForce1 = 500f;
    public float sidewaysForce2 = -500f;
    public float backForce = -500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce1 * Time.deltaTime, 0, 0);
        }
        
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(sidewaysForce2 * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0 , 0, forwardForce1 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0 , 0, backForce * Time.deltaTime);
        }

    }
        
    }

