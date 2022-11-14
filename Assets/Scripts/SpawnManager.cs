using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    //public GameObject player;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        

        Vector3 spawnPositionTop = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Vector3 spawnPositionLeft = new Vector3(-spawnRangeX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Vector3 spawnPositionRight = new Vector3(spawnRangeX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));


        Instantiate(animalPrefabs[animalIndex], spawnPositionTop, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex], spawnPositionLeft, Quaternion.Euler(0, -270, 0));
        Instantiate(animalPrefabs[animalIndex], spawnPositionRight, Quaternion.Euler(0, 270, 0));

        //Instantiate(animalPrefabs[animalIndex], spawnPositionZ, animalPrefabs[animalIndex].transform.rotation);
    }


}
