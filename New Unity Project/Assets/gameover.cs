using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public GameObject GameObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Jammo_LowPoly")
            GameObject.SetActive(true);
    }
}
