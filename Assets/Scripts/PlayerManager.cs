using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject carrot;
    private float hInput,vInput;
    private float playerSpeed = 24.0f;
    private float rightBorder = 23.0f;
    private float leftBorder = -23.0f;
    private float topBorder = 10.0f;
    private float bottomBorder = -14.0f;
    
    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        moveForce(Vector3.right,hInput);
        moveForce(Vector3.forward,vInput);
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(carrot,
                        new Vector3(transform.position.x,transform.position.y,transform.position.z),
                        carrot.transform.rotation);
        }

        if(transform.position.x >= rightBorder){
            transform.position = new Vector3(rightBorder,transform.position.y,transform.position.z);
        }
        if(transform.position.x <= leftBorder){
            transform.position = new Vector3(leftBorder,transform.position.y,transform.position.z);
        }
        if(transform.position.z >= topBorder){
            transform.position = new Vector3(transform.position.x,transform.position.y,topBorder);
        }
        if(transform.position.z <= bottomBorder){
            transform.position = new Vector3(transform.position.x,transform.position.y,bottomBorder);
        }

    }


void moveForce(Vector3 direction, float moveInput){
    transform.Translate(direction*moveInput*Time.deltaTime*playerSpeed);
}

}
