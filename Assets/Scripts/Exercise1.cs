using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise1 : MonoBehaviour
{
    public TextMeshProUGUI number;
    //Range of the random number
    private int min = 0;
    private int max = 100;
   
    //A random number from 0 to 100 is generated
    public void RandomNumber()
    {
        //The random number is showed on the screen
        number.text = Random.Range(min, max).ToString();
    }
}
