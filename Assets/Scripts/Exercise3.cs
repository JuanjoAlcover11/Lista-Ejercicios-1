using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    private float xPos, yPos, zPos;

    private float xRange = 8f;
    private float yRange = 4f;
    private float zRange = 8f;

    void Update()
    {
        //If you press "Enter"...
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Generates a random position 
            xPos = Random.Range(-xRange, xRange);
            yPos = Random.Range(-yRange, yRange);
            zPos = Random.Range(-zRange, zRange);
            //The cube is moved to that position
            transform.position = new Vector3(xPos, yPos, zPos);
        }
    }
}
