using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text skorTXT;
    [SerializeField] private Text waveTXT;
    public static int skor;
    
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        skorTXT.text = "Skor; " + skor.ToString();
        waveTXT.text = "Wave: " + SpawnpointScripts.wave.ToString();

        if (skor >= 350 && skor <= 780)
        {
            SpawnpointScripts.wave = 2;
        }
        else if (skor >= 780)
        {
            SpawnpointScripts.wave = 3;
        }


       



       
    }
}
