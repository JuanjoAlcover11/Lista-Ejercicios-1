using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public GameObject sphere;

    private Material sphereMaterial;

    private void Start()
    {
        //Get the material from the sphere
        sphereMaterial = sphere.GetComponent<Renderer>().material;
    }

    //The transparency of the sphere changes when you move the glider
    public void ChangeAlpha(float value)
    {
        sphereMaterial.color = new Vector4(sphereMaterial.color.r, sphereMaterial.color.g, sphereMaterial.color.b, value);
    }
}
