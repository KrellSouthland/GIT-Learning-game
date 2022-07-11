using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public float pipeDistance = 7f;

 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(collision.gameObject, new Vector2(collision.gameObject.transform.position.x + pipeDistance, Random.Range(0.5f, 5.3f)), Quaternion.identity);
    }
}
