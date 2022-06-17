using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usa_shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn = null;
    public float reloadTime;
    public AudioClip gun;

    AudioSource fuenteaudio;
    float currReloadTime;
    
    void Start()
    {
        currReloadTime = reloadTime;

        fuenteaudio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (currReloadTime > 0)
        {
            currReloadTime -= Time.deltaTime;
        }
        
        if (Input.GetMouseButton(0) && currReloadTime <= 0)
        {
            var b = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
            
            currReloadTime = reloadTime;
            fuenteaudio.clip = gun;
            fuenteaudio.Play();

        }               
        }
    
}
