using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject bullet;
    public Transform spawnPoint;

    public float shotForce = 1500;
    public float shotRate = 0.5f;

    private float shotRateTime = 0;
    public GameObject newBullet;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("a");
                
                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);

                //shotRateTime= Time.time + shotRate;
                
                Destroy(newBullet, 2);
            
        }
    }
}
