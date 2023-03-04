using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSystem : MonoBehaviour
{
    [SerializeField] private GameObject randomBTN1;
    [SerializeField] private GameObject randomBTN2;
    [SerializeField] private GameObject randomBTN3;
    [SerializeField] private string[] upgrades;
    int random1;
    int random2;
    int random3;
    string butonIciText;

    public GameObject UpgradePanel;

    newNamluScripts player;
    public GameObject playerScript;


    void Start()
    {
        player = playerScript.GetComponent<newNamluScripts>();

        
    }

    // Update is called once per frame
    void Update()
    {

        WaveTimer();    

    }

    public void buttonaBasildi()
    {
        butonIciText = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text;
        newNamlu();
        AttackSpeed();
        
    }

    void newNamlu()
    {
        if (butonIciText == "+1 Namlu")
        {
            player.enabled = true;

            UpgradePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    void AttackSpeed()
    {
        if (butonIciText == "Ateş Hızı")
        {
            PlayerControlerScripts.fireRate += 2;
            UpgradePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }



    void PanaleAvtive()
    {
       
        
        random1 = Random.Range(0, upgrades.Length);
        random2 = Random.Range(0, upgrades.Length);
        random3 = Random.Range(0, upgrades.Length);
        
        GameObject.Find("random1").GetComponentInChildren<Text>().text = upgrades[random1];
        GameObject.Find("random2").GetComponentInChildren<Text>().text = upgrades[random2];
        GameObject.Find("random3").GetComponentInChildren<Text>().text = upgrades[random3];
        


    }

    void WaveTimer()
    {

        if (SpawnpointScripts.wave == 2)
        {
            UpgradePanel.SetActive(true);
            PanaleAvtive();
            Time.timeScale = 0;


        }
    }


    public void DeAvtivePanel()
    {
        UpgradePanel.SetActive(false);
    }
}

