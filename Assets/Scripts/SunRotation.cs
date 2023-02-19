using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotation : MonoBehaviour
{

    private Vector3 rotation;
    private float dayLength=0.5f;
    private float _rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rotation = Time.deltaTime/dayLength;
        transform.Rotate(0,_rotation,0);
    }
}
