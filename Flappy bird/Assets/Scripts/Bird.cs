using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public Rigidbody2D bird;
    public float fly = 10f;
    public Text count;
    private int res = 0;
    public MainScript life;
    public float grav = 1.15f;





    void FloatUp() // метод, заставл€ющий птичку взлетать
    {
       if (Input.GetKeyDown(KeyCode.Space))
            bird.velocity = new Vector2(bird.velocity.x, fly);

       if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase==TouchPhase.Began)
            {
                bird.velocity = new Vector2(bird.velocity.x, fly);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="count")
        {
            res = res + 1;
            count.text = Convert.ToString(res);
        }
        else  if (collision.tag == "pipe")
            {
                life.death = true;
                life.GameOver();
            }
        

    }

    void Update()
    {
        if (life.death == true)
        {
            bird.gravityScale = 0.0f;
        }
        else
        {
            bird.gravityScale = grav;
            FloatUp();
        }
    }
}
