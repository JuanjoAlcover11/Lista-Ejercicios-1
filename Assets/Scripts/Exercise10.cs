using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise10 : MonoBehaviour
{
    public TextMeshProUGUI counter;

    private int score = 0;

    private void Start()
    {
        //The counter starts at 0
        counter.text = score.ToString();
    }

    //Add a point to the score
    public void AddPoint()
    {
        score++;

        counter.text = score.ToString();
    }
    private void OnMouseOver()
    {
        //If you click on a spheres
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Add a point to the score
            AddPoint();

            //Destroy the spheres
            Destroy(gameObject);
        }
    }

}
