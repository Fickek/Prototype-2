using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounce : MonoBehaviour
{

    private float topBound = 30;
    private float lowerBound = -10;
    private float rightBound = 20;
    private float leftBound = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound || transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound || transform.position.x < leftBound)
        {
            //Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}
