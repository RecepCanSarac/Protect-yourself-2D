using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlerScripts : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float Force;
    public float fireRate;

    float nextTimeFire = 0;

    void Start()
    {
        
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
