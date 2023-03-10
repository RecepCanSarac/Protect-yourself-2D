using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlerScripts : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootPoint;
    [SerializeField] public static float Force;
    public static float fireRate;
    newNamluScripts namlu;
    DoubleFire fire;
    float nextTimeFire = 0;

    void Start()
    {
        fire = GetComponent<DoubleFire>();
        namlu = GetComponent<newNamluScripts>();
        namlu.enabled = false;
        fire.enabled = false;
        Force = 750;
        fireRate = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextTimeFire)
        {
            nextTimeFire = Time.time + 1 / fireRate;
            shoot();
        }
        mousePosition();
        Debug.Log(fireRate);
    }

    private void mousePosition()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = mousePos;
    }
    private void shoot()
    {
        GameObject bulletIns =  Instantiate(bullet,shootPoint.position,transform.rotation);
        bulletIns.GetComponent<Rigidbody>().AddForce(transform.up * Force);
        Destroy(bulletIns,1.5f);
    }
}
