using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    private float xPos, yPos, zPos;

    private float xRange = 8f;
    private float yRange = 4f;
    private float zRange = 8f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            xPos = Random.Range(-xRange, xRange);
            yPos = Random.Range(-yRange, yRange);
            zPos = Random.Range(-zRange, zRange);

            transform.position = new Vector3(xPos, yPos, zPos);
        }
    }
}
