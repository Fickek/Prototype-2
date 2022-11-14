using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool dogIsSpawn = true;
    //private float startSpawn = 0;
    //private float spawnInterval = 5;


    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) & dogIsSpawn)
        {
            SpawnDog();
            dogIsSpawn = false;
            
        }

        if(dogIsSpawn == false)
        {
            InvokeRepeating("Pause", 0, 5);
        }

        
    }

    // Update is called once per frame
    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

    void Pause()
    {
        dogIsSpawn = true;
    }

}
