using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;
    float force = 6f;

    void Start()
    {
       
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Object" && gameObject.tag == "Door" || collisionInfo.collider.tag == "ObjectStrong" && gameObject.tag == "Door")
        {
            OnDestroy();
            Instantiate(destroyedVersion, transform.position, transform.rotation);
        }
        
        if (collisionInfo.collider.tag == "Door" && gameObject.tag == "Object" || collisionInfo.collider.tag == "DoorStrong" && gameObject.tag == "Object")
        {
            OnDestroy();
            Instantiate(destroyedVersion, transform.position, transform.rotation);
        }

        if (collisionInfo.collider.tag == "DoorStrong" && gameObject.tag == "ObjectStrong")
        {
            OnDestroy();
            Instantiate(destroyedVersion, transform.position, transform.rotation);
        }

        if (collisionInfo.collider.tag == "ObjectStrong" && gameObject.tag == "DoorStrong")
        {
            OnDestroy();
            Instantiate(destroyedVersion, transform.position, transform.rotation);
        }
    }

    private void OnDestroy()
    {
        Destroy(gameObject);
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(100, 100, 100) * force);
    }
}
