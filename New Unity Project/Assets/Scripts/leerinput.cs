using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leerinput : MonoBehaviour
{

    public  TMPro.TMP_InputField inputField;
    public TMPro.TMP_Text nombre;
    public void getData()
    {
        string cadena = "";
        cadena = inputField.text;
        Debug.Log(cadena);

        PlayerPrefs.SetString("nombre",cadena);

        Debug.Log("el nombre en el playerprefs es: "+PlayerPrefs.GetString("nombre"));
    }

    public void SetInputText(string inputText)
    {
        nombre.text = inputText;
        Debug.Log(inputText);
    }


}
