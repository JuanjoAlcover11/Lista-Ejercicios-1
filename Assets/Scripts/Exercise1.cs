using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise1 : MonoBehaviour
{
    public TextMeshProUGUI number;

    private int min = 0;
    private int max = 100;
   
    public void RandomNumber()
    {
        number.text = Random.Range(min, max).ToString();
    }
}
