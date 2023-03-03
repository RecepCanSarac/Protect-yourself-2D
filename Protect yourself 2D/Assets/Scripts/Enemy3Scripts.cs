using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Scripts : MonoBehaviour
{
    int enemy3Health = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            enemy3Health--;
            Destroy(collision.gameObject);
            if (enemy3Health == 0)
            {
                GameManager.skor += 27;
                Destroy(gameObject);
            }
        }
    }
}
