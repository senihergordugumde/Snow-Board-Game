using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
     
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "head")
        {
            Debug.Log("Öldün");
        } 
    }
}