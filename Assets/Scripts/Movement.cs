 using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Target;
    Vector3 TargetPosition;
    Vector3 Myposition;
    private Vector3 Velocity ;
    public float Speed ; 
    private Rigidbody rb ;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        TargetPosition = Target.transform.position;
        Myposition = transform.position;
        TargetPosition.y = Myposition.y;
        float DistanceToTarget = (TargetPosition - Myposition).magnitude;
        float MinDistance = 1f;
        if(DistanceToTarget > MinDistance)
        {
           
            
            Vector3 direction = (TargetPosition - Myposition).normalized;
            Velocity = direction * Speed;
            Velocity.y = rb.velocity.y;
            rb.velocity = Velocity;







            transform.forward = direction;
        }
     
    }
}
