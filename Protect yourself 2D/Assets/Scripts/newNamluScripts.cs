using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newNamluScripts : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootPoint;
    public float fireRate;
    int force;
    float nextTimeFire = 0;
    void Start()
    {
        force = -750;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextTimeFire)
        {
            nextTimeFire = Time.time + 1 / fireRate;
            shoot();
        }
    }
    private void shoot()
    {
        GameObject bulletIns = Instantiate(bullet, shootPoint.position, transform.rotation);
        bulletIns.GetComponent<Rigidbody>().AddForce(transform.up * force);
        Destroy(bulletIns, 1.5f);
    }
}
