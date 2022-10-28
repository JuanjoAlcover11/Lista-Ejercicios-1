using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ejercicio2 : MonoBehaviour
{
    public int num;
    public TextMeshProUGUI text;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (num % 2 == 0)
            {
                text.text = "The number " + num + " is even";
            }
            else
            {
                text.text = "The number " + num + " is odd";
            }
        }
    }
}
