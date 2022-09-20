using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Collision : MonoBehaviour
{   

    [SerializeField] float magicnumber = 1f;
    [SerializeField] ParticleSystem particle2;

   
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "head")
        {
           Invoke("Reload",magicnumber);
        } 
     
        if (other.tag == "Player")
        {
            particle2.Play();
        }

    }
    void OnCollisionExit2D(Collision2D other)
    {
        particle2.Stop();
    }
       

   

    void Reload()
    {
        SceneManager.LoadScene(0);

    }
}
