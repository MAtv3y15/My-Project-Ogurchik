using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UnitAnimation : MonoBehaviour
{
private Rigidbody Rb;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        Rb= GetComponent<Rigidbody>();  
    }
   
    // Start is called before the first frame update
    void Update()
    {
        if (Rb.velocity.magnitude > 1)
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }
    }
  
}
