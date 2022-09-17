using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float magicnumber = 1f;
    [SerializeField] ParticleSystem partical;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {   
           partical.Play();
           Invoke("Reload",magicnumber);
        }

    }

    void Reload()
    {
        SceneManager.LoadScene(0);

    }
}
