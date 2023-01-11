using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerAnim : MonoBehaviour
{

    float rotationSpeed = 1f;
    Vector3 currentEulerAngles;
    Quaternion currentRotation;
    int dongu = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (dongu == 0)
        {
            if (transform.rotation.x > 0)
            {
                transform.Rotate(90 * Time.deltaTime * rotationSpeed, 0, 0);
            }
            if (transform.eulerAngles.x < 1 && transform.eulerAngles.x > -1)
            {
                Debug.Log(transform.rotation + "----" + dongu);
            }
        }

        if (dongu == 1)
        {
            if (transform.rotation.x < 90)
            {
                transform.Rotate(-90 * Time.deltaTime * rotationSpeed, 0, 0);
            }
            if (transform.eulerAngles.x == 90)
            {
                dongu = 0;
                Debug.Log(dongu);
            }
        }




        /*if (transform.eulerAngles.x == 180)
        {
            currentEulerAngles.x += 90 * Time.deltaTime * rotationSpeed;
            currentRotation.eulerAngles = new Vector3(currentEulerAngles.x, 90, 0);
            transform.rotation = currentRotation;
        }

        if (transform.eulerAngles.x == 90)
        {
            currentEulerAngles.x += -90 * Time.deltaTime * rotationSpeed;
            currentRotation.eulerAngles = new Vector3(currentEulerAngles.x, 90, 0);
            transform.rotation = currentRotation;
        }*/

    }
}

