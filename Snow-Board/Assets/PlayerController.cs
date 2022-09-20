using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float speedUp = 10f;
    [SerializeField] float baseSpeed = 6.25f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector;

    bool isControl = true;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (isControl == true)
        {
             control();
        }
    }

    public void DisableControl()
    {
        isControl = false;
    }
    void control()
    {

        
    
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = speedUp;
        }

        else
        {
            surfaceEffector.speed = baseSpeed;
        }
        
        
    }
}
