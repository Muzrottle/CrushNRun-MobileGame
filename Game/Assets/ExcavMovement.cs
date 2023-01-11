    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcavMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 10000f;
    public float sidewayForce = 75f;
    public float gravityForce = 200000f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started!");
    }

    // Update is called once per frame. We called it fixed
    // because we are messing with physics.
    void FixedUpdate()
    {
        // Add a forward force each frame. We used deltatime to fix it on 200.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        rb.AddForce(0, gravityForce * Time.deltaTime, 0);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
