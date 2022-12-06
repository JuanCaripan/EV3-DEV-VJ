using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio_escena : MonoBehaviour
{
    private void Onclick()
    {
        SceneManager.LoadScene("argame");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            SceneManager.LoadScene("argame");

        }
    }
}
