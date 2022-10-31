using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using TMPro;


public class Exercise8 : MonoBehaviour
{
    public TMP_InputField username;
    public TextMeshProUGUI message;

    //Expressions that only allows to use valid characters
    private string expression = "^[A-Za-z0-9_.]+$";

    public void Confirm()
    {
        //Checks the username
        if (Regex.IsMatch(username.text, expression))
        {
            message.text = "Hello " + username.text + ", welcome to this amazing adventure!";
        }
    }
}
