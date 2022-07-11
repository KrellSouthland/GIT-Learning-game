using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public Rigidbody2D piperb;
    public float pipeSpeed = -3f;
    public bool death=false;
    public MainScript mainScript;
 
    void MoveAction()//движение уровня
    {

            piperb.velocity = new Vector2(pipeSpeed, piperb.velocity.y);

    }
 
   
    void Start()
    {
        piperb = GetComponent<Rigidbody2D>();
       

    }
    void Update()
    {
        if (mainScript.death == false)
        { MoveAction(); }
        else
        {
            piperb.velocity = new Vector2(0, piperb.velocity.y);
        }
    }
}
