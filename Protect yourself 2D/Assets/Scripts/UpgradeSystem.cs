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



    newNamluScripts player;
    public GameObject playerScript;


    void Start()
    {
        player = playerScript.GetComponent<newNamluScripts>();
        random1 = Random.Range(0, upgrades.Length);
        random2 = Random.Range(0, upgrades.Length);
        random3 = Random.Range(0, upgrades.Length);

        if (random1 == random2)
        {
            random1 = Random.Range(0, upgrades.Length);
            
        }
        else if (random1 == random3 )
        {
            random3 = Random.Range(0, upgrades.Length);
        }
        else if (random3 == random2)
        {
            random2 = Random.Range(0, upgrades.Length);
        }
        GameObject.Find("random1").GetComponentInChildren<Text>().text = upgrades[random1];
        GameObject.Find("random2").GetComponentInChildren<Text>().text = upgrades[random2];
        GameObject.Find("random3").GetComponentInChildren<Text>().text = upgrades[random3];
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void buttonaBasildi()
    {
        butonIciText = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text;
        newNamlu();
        button2Func();
    }

    void newNamlu()
    {
        if (butonIciText == "+1 Namlu")
        {
            player.enabled = true;
        }
    }

    void button2Func()
    {
        if (butonIciText == "Delici Mermi ")
        {
            Debug.Log("Mermiler Delsin");
        }
    }
}
