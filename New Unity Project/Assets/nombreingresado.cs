using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nombreingresado : MonoBehaviour
{
    public TMPro.TMP_Text nombre;

    public void SetInputText(string inputText)
    {
        nombre.text = inputText;
    }
}