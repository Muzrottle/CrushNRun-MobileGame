using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    private Animator animator;
    public PlayerMovementTest playerMovementTest;
    private Rigidbody rb;
    public bool isHolding = false;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        


        if (Input.GetKeyDown("f"))
        {
            animator.SetTrigger("Pickup");
        }


        if (Input.GetKey("f"))
        {
            isHolding = true;
        }
        
    }


}