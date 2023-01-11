using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 7.0f;
    private CharacterController myCharacterController;
    public GameObject completeLevelUI;
    public GameObject failLevelUI;
    Vector3 movec = Vector3.zero;
    bool canmove = true;
    int line = 1;
    int targetLine = 1;


    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 pos = gameObject.transform.position;
        if (!line.Equals(targetLine))
        {
            if (targetLine == 0 && pos.x < -4)
            {
                gameObject.transform.position = new Vector3(-4, pos.y, pos.z);
                line = targetLine;
                movec.x = 0;
                canmove = true;
            }
            else if (targetLine == 1 && (pos.x > 0 || pos.x < 0)){
                if (line == 0 && pos.x > 0)
                {
                    gameObject.transform.position = new Vector3(0, pos.y, pos.z);
                    line = targetLine;
                    movec.x = 0;
                    canmove = true;
                }
                else if (line == 2 && pos.x < 0)
                {
                    gameObject.transform.position = new Vector3(0, pos.y, pos.z);
                    line = targetLine;
                    movec.x = 0;
                    canmove = true;
                }
            }else if (targetLine == 2 && pos.x > 4)
            {
                gameObject.transform.position = new Vector3(4, pos.y, pos.z);
                line = targetLine;
                movec.x = 0;
                canmove = true;
            }
        }
        
        checkInputs();
        if (!myCharacterController.isGrounded)
        {
            movec.y = -4;
        }
        myCharacterController.Move(movec*Time.deltaTime);
    }

    void checkInputs()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && canmove && line > 0)
        {
            targetLine--;
            canmove = false;
            movec.x = -8f;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && canmove && line < 2){
            targetLine++;
            canmove = false;
            movec.x = 8f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        myCharacterController.SimpleMove(new Vector3(0f, 0f, 0f));
        myCharacterController.Move(transform.forward * speed * Time.deltaTime);


        if (completeLevelUI.activeSelf == true)
        {
            speed = 0f;
        }
        else if (failLevelUI.activeSelf == true)
        {
            speed = 0f;
        }
    }

    void Speed()
    {
        speed = 7.0f;
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.name == "Door")
        {
            Physics.IgnoreCollision(collisionInfo.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        }

        if (collisionInfo.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("Carbtým!");
        }
        
    }
  
}
