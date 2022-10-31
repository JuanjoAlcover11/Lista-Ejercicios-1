using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Exercise2 : MonoBehaviour
{
    public int num;
    public TextMeshProUGUI text;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //If the number is even...
            if (num % 2 == 0)
            {
                //... show this message on screen
                text.text = "The number " + num + " is even";
            }
            //If the number is odd...
            else
            {
                //... show this message on screen
                text.text = "The number " + num + " is odd";
            }
        }
    }
}
