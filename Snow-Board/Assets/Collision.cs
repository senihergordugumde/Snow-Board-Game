using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Collision : MonoBehaviour
{
     
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            SceneManager.LoadScene(0);
            Debug.Log("Öldün");
        } 
    }
}
