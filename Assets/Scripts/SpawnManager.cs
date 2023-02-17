using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalObjects;
    private int rightBorder = 23;
    private int leftBorder = -23;
    private int topBorder = 10;
    private int bottomBorder = -8;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal",2.0f,2.0f);
        InvokeRepeating("SpawnRightAnimal",20.0f,2.0f);
        InvokeRepeating("SpawnLeftAnimal",30.0f,2.0f);
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

    void SpawnRightAnimal(){
                int index = Random.Range(0,animalObjects.Length);
                int zPosition = Random.Range(topBorder,bottomBorder);
                Vector3 newPosition = new Vector3(-40,animalObjects[index].transform.position.y,-zPosition);
                Vector3 newRotation = new Vector3(0,90,0);
                Instantiate(animalObjects[index],
                            newPosition,
                            Quaternion.Euler(newRotation));
    }
    void SpawnLeftAnimal(){
                int index = Random.Range(0,animalObjects.Length);
                int zPosition = Random.Range(topBorder,bottomBorder);
                Vector3 newPosition = new Vector3(40,animalObjects[index].transform.position.y,-zPosition);
                Vector3 newRotation = new Vector3(0,-90,0);
                Instantiate(animalObjects[index],
                            newPosition,
                            Quaternion.Euler(newRotation));
    }
}
