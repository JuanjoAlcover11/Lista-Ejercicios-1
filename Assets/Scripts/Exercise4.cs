using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public GameObject sphere;

    public void ChangeObjectScale(float n)
    {
        //When you move the slider, the scale of the sphere changes
        sphere.transform.localScale = new Vector3(n, n, n);
    }
}
