using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectmovement : MonoBehaviour
{
    private float speed = 25.0f;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "Chick"){
            speed = 5.0f;
        }if(gameObject.tag == "Dog"){
            speed = 8.0f;
        }if(gameObject.tag == "Moose"){
            speed = 10.0f;
        }


        transform.Translate(Vector3.forward*speed*Time.deltaTime);


        if(transform.position.z <= -30.0f){
            Debug.Log("They are attacking the Farmhouse! Stop Them!");
            Destroy(gameObject);
        }
    }
}
