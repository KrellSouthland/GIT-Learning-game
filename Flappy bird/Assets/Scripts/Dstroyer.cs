using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dstroyer : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D destroyCollider)
    {
        Destroy(destroyCollider.gameObject);
    }
}
