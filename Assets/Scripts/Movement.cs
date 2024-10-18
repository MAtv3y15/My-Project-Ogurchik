 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 Velocity ;
    public float Speed ; 
    public Rigidbody rb ;
    public 
    void Update()
    {
        Velocity.z = Input.GetAxis("Vertical") * Speed;
       Velocity.x = Input.GetAxis("Horizontal") *  Speed ;
     Velocity.y = rb.velocity.y;
      rb.velocity = Velocity;
    }
}
