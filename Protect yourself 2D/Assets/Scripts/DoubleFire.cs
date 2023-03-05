using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleFire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootPoint;
    [SerializeField] public static float Force;
    public static float fireRate;
    float nextTimeFire = 0;
    void Start()
    {
        Force = 750;
        fireRate = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextTimeFire)
        {
            nextTimeFire = Time.time + 1 / PlayerControlerScripts.fireRate;
            shoot();
        }
        
    }
    private void shoot()
    {
        GameObject bulletIns = Instantiate(bullet, shootPoint.position, transform.rotation);
        bulletIns.GetComponent<Rigidbody>().AddForce(transform.up * Force);
        Destroy(bulletIns, 1.5f);
    }
}
