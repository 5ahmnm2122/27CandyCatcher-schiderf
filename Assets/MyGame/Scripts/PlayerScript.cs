using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb2d; 
    private int speed = 4;


    

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    //Put physica based movement in here
    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.velocity = new Vector2(speed, 0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.velocity = new Vector2(- speed, 0);           
        }
        else
        {   
            rb2d.velocity = new Vector2(0, 0);
        }
    }
}

