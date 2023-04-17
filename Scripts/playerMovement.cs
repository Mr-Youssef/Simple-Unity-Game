using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 500f;
    public float sidewaysForce = 200f;
    public float speed = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Unity loves FixedUpdate when using physics such as force, acceleration,etc..
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        //if (Input.GetKey("d"))
        //{
        //    rb.AddForce(sidewaysForce, 0, ForwardForce * Time.deltaTime);
        //}
        //if (Input.GetKey("a"))
        //{
        //    rb.AddForce(-sidewaysForce, 0, ForwardForce * Time.deltaTime);
        //}
        float horizontalDirection = Input.GetAxis("Horizontal");
        float verticalDirection = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalDirection, 0, verticalDirection);
        transform.position += direction * speed * Time.deltaTime;
    }
}
