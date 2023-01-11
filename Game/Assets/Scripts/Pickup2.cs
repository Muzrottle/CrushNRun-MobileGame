using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup2 : MonoBehaviour
{

    float throwForce = 7f;
    Vector3 objectPos;
    float distance;

    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;

    // Update is called once per frame
    void Update()
    {

        distance = Vector3.Distance(item.transform.position, tempParent.transform.position);
        if (distance >= 1f)
        {
            isHolding = false;
        }
        //Check if isholding
        if (isHolding == true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);

            if (Input.GetKeyDown("l"))
            {
                item.GetComponent<Rigidbody>().AddForce(new Vector3(0, 30, 90) * throwForce);
                isHolding = false;
            }
            if (Input.GetKeyDown("k"))
            {
                item.GetComponent<Rigidbody>().AddForce(new Vector3(0, 30, 90) * throwForce);
                isHolding = false;
            }
        }
        else
        {
            objectPos = item.transform.position;
            item.transform.SetParent(null);
            item.GetComponent<Rigidbody>().useGravity = true;
            item.transform.position = objectPos;
        }

        if (Input.GetKey("f" /* && isHolding */ ))
        {
            isHolding = true;
            item.GetComponent<Rigidbody>().useGravity = false;
            item.GetComponent<Rigidbody>().detectCollisions = true;
        }

        if (Input.GetKey("q"))
        {
            isHolding = false;
        }
    }
}