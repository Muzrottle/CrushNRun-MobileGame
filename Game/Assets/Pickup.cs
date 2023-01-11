using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform dest;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("f" /* && isHolding */ ))
        {
            GetComponent<SphereCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = dest.position;
            this.transform.parent = GameObject.Find("Destination").transform;
        }
        
        if(Input.GetKey("q"))
        {
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<SphereCollider>().enabled = true;
        }
    }
}
