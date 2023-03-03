using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text skorTXT;
    [SerializeField] private Text waveTXT;
    public bulletScripts Bulletscripts;
    public float skor;
    public int wave;
    void Start()
    {
       
        skor = 0;
        wave = 1;
    }

    // Update is called once per frame
    void Update()
    {
        skorTXT.text = "Skor; " + skor.ToString();
        waveTXT.text = "Wave: " + wave.ToString();

        if (skor == 100)
        {
            wave = 2;
        }
        else if (skor == 350)
        {
            wave = 3;
        }
    }
}
