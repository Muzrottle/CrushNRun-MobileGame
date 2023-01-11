using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Quaternion quaternion;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        transform.rotation = Quaternion.Euler(30, 0, 0);

    }


}