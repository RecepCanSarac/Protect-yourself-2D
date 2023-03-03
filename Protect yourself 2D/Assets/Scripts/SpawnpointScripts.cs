using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnpointScripts : MonoBehaviour
{
    [SerializeField] GameObject enemy1;
    [SerializeField] GameObject enemy2;
    [SerializeField] GameObject enemy3;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] float enemy1Timer;
    [SerializeField] float enemy2Timer;
    [SerializeField] float enemy3Timer;
    public static int wave;
    //public GameManager gameManager;
    //GameManager gamemanagerr;
     
    void Start()
    {
        wave = 1;
     
        enemy2.active = false;
        enemy3.active = false;
        StartCoroutine(spawnEnemy(enemy1Timer, enemy1));
        StartCoroutine(spawnEnemy(enemy2Timer, enemy2));
        StartCoroutine(spawnEnemy(enemy3Timer, enemy3));
    }
    private void Update()
    {
        if (wave == 2)
        {
            enemy2.active = true;
        }
        else if (wave == 3)
        {
            enemy2.active = true;
            enemy3.active = true;
        }
    }

    private IEnumerator spawnEnemy(float time ,GameObject enemy)
    {
        yield return new WaitForSeconds(time);
        int randomSpawn = Random.Range(0,48);
        GameObject newEnemy = Instantiate(enemy, spawnPoints[randomSpawn].position,Quaternion.identity);
        StartCoroutine(spawnEnemy(time, enemy));
        
    }
}
