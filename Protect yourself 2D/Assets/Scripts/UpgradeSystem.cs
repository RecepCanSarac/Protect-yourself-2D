using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSystem : MonoBehaviour
{
    [SerializeField] private string[] UpgradesTexts;
    [SerializeField] private GameObject Random1,Random2,Random3,UpgradePanel,newGUN;
    private int random1, random2, random3;
    string ButtonTXT;
    newNamluScripts newGunScripts;


    void Start()
    {
        newGunScripts = newGUN.GetComponent<newNamluScripts>();
        random1 = Random.Range(0,UpgradesTexts.Length);
        random2 = Random.Range(0,UpgradesTexts.Length);
        random3 = Random.Range(0,UpgradesTexts.Length);
        if (random1 == random2)
        {
            random1 = Random.Range(0, UpgradesTexts.Length);
            random2 = Random.Range(0, UpgradesTexts.Length);
        }
        else if (random1 == random3)
        {
            random1 = Random.Range(0, UpgradesTexts.Length);
            random3 = Random.Range(0, UpgradesTexts.Length);
        }
        else if (random2 == random3)
        {
            random2 = Random.Range(0, UpgradesTexts.Length);
            random3 = Random.Range(0, UpgradesTexts.Length);
        }
    }

    
    void Update()
    {
        if (UpgradePanel.active == true)
        {
            GameObject.Find("Random1").GetComponentInChildren<Text>().text = UpgradesTexts[random1];
            GameObject.Find("Random2").GetComponentInChildren<Text>().text = UpgradesTexts[random2];
            GameObject.Find("Random3").GetComponentInChildren<Text>().text = UpgradesTexts[random3];
        }
    }

    public void ButtonActive()
    {
        ButtonTXT = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text;
        Debug.Log(ButtonTXT);
        random1 = Random.Range(0, UpgradesTexts.Length);
        random2 = Random.Range(0, UpgradesTexts.Length);
        random3 = Random.Range(0, UpgradesTexts.Length);
        if (random1 == random2)
        {
            random1 = Random.Range(0, UpgradesTexts.Length);
            random2 = Random.Range(0, UpgradesTexts.Length);
        }
        else if (random1 == random3)
        {
            random1 = Random.Range(0, UpgradesTexts.Length);
            random3 = Random.Range(0, UpgradesTexts.Length);
        }
        else if (random2 == random3)
        {
            random2 = Random.Range(0, UpgradesTexts.Length);
            random3 = Random.Range(0, UpgradesTexts.Length);
        }
        newGun();
        AttackSpeed();
        UpgradePanel.SetActive(false);
    }


    private void newGun()
    {
        if (ButtonTXT == "+1 Gun")
        {
            newGunScripts.GetComponent<newNamluScripts>().enabled = true;
        }
    }

    private void AttackSpeed()
    {
        if (ButtonTXT == "Attack Speed")
        {
            PlayerControlerScripts.fireRate += 2;
        }
    }
    private void DoubleFire()
    {
        if (ButtonTXT == "Double Fire")
        {
            newGunScripts.GetComponent<DoubleFire>().enabled = true;
        }
    }

}
