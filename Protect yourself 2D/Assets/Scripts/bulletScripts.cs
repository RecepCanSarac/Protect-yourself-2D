using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScripts : MonoBehaviour
{
    
    private int Enemy1Health;
    private int Enemy2Health;
    private int Enemy3Health;
    //GameManager gamemenegr;
    //public GameObject gameMANAGER;
    void Start()
    {
        //gamemenegr = gameMANAGER.GetComponent<GameManager>();
        Enemy2Health = 2;
        Enemy3Health = 3;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            Destroy(collision.gameObject);
            //gamemenegr.skor += 10;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy2"))
        {
            Enemy2Health--;
            if (Enemy2Health <= 0)
            { 
                Destroy(collision.gameObject);
                //gamemenegr.skor += 25;
            }
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy3"))
        {
            Enemy3Health--;
            if (Enemy3Health >= 0)
            {
                Destroy(collision.gameObject);
               // gamemenegr.skor += 35;
            }
            Destroy(gameObject);
        }
    }
}
