using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6 : MonoBehaviour
{
    public GameObject cylinder;

    private Material objMaterial;

    private void Start()
    {
        //Get the material from the cylinder
        objMaterial = cylinder.GetComponent<Renderer>().material;
    }

    //Assign the color you pick from the dropdown to the cylinder
    public void ChangeColor(int index)
    {
        switch (index)
        {
            case 0:
                objMaterial.color = Color.red;
                break;

            case 1:
                objMaterial.color = Color.blue;
                break;

            case 2:
                objMaterial.color = Color.green;
                break;

            case 3:
                objMaterial.color = Color.yellow;
                break;

            case 4:
                objMaterial.color = Color.black;
                break;

            default:
                objMaterial.color = Color.red;
                break;
        }
    }
}
