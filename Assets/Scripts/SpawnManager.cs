using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalObjects;
    private int rightBorder = 23;
    private int leftBorder = -23;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal",2.0f,2.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnAnimal(){
        int index = Random.Range(0,animalObjects.Length);
        int xPosition = Random.Range(leftBorder,rightBorder);
        Instantiate(animalObjects[index],
                    new Vector3(xPosition,
                            transform.position.y,
                            animalObjects[index].transform.position.z),
                    animalObjects[index].transform.rotation);
    }
}
