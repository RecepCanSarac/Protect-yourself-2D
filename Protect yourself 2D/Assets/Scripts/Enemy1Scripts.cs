using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Scripts : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            GameManager.skor += 12;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
