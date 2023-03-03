using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Scripts : MonoBehaviour
{
    int enemy2Health = 2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            enemy2Health--;
            Destroy(collision.gameObject);
            if (enemy2Health == 0)
            {
                GameManager.skor += 23;
                Destroy(gameObject);
            }
        }
    }
}
