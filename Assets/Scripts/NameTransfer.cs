using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameTransfer : MonoBehaviour
{

    public static string PlayerName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        PlayerName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Welcome " + PlayerName;
    }


}
