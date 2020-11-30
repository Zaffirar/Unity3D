using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;

    public float fowardForce = 4000f;
    public float sidewaysForce = 100f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame + physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);
        float x=Input.GetAxis("Horizontal");
        if(x>0.0)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(x<0.0){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
