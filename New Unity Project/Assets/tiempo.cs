using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiempo : MonoBehaviour
{
    public Text UITexto;
    private int contador = 0;
    private void Awake()
    {
        InvokeRepeating("Cronometro", 0f, 1f);
    }
    void Cronometro()
    {
        if (contador != 30)
        {
            contador++;
            UITexto.text = "Tiempo: " + contador.ToString();
        }
        else
        {
            UITexto.text = "Fuera de Tiempo";
        }
    }
}
