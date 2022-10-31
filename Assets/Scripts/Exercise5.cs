using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    public GameObject capsule;
    public Vector3[] positions;

    void Update()
    {
        //If you press the key "s"...
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Find the objects witrh the tag "capsule"
            GameObject[] capsules = GameObject.FindGameObjectsWithTag("Capsule");

            foreach (Vector3 position in positions)
            {
                //Instantiate the capsules
                Instantiate(capsule, position, capsule.transform.rotation);
            }
        }
    }
}
