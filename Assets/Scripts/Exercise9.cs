using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise9 : MonoBehaviour
{
    public Toggle lightToggle;
    public GameObject pointLight;

    private void Start()
    {
        //The light is on by default
        ChangeLight(lightToggle.isOn);
    }

    public void ChangeLight(bool isOn)
    {
        //If the light is on...
        if (isOn)
        {
            //Turn it off
            pointLight.GetComponent<Light>().enabled = true;
        }
        else
        {
            //Turn it on
            pointLight.GetComponent<Light>().enabled = false;
        }
    }
}
