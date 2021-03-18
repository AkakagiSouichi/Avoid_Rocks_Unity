using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitychanani : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {

            animator.SetBool("Running", true);
        }
        else  if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Running", true);
        }
        else  if (Input.GetKey(KeyCode.W))
        {

            animator.SetBool("Running", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Running", true);
        }
        else
        {
            animator.SetBool("Running", false);
        }

    }

}
       

       
  

