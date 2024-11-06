using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UnitAnimation : MonoBehaviour
{
public Rigidbody Rb;
    public Animator animator;
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
