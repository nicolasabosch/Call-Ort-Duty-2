using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class muerte_personaje : MonoBehaviour
{
     public GameObject personaje;
     bool vivo=true;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Zombie") {
            Debug.Log("moriste");
            vivo = false;
        }
    }


    private void OnCollisionEnter(Collider other)
    {

        Debug.Log("moriste");
        vivo=false;
    }
    // Update is called once per frame
    void Update()
    {
        



        if (vivo== false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            
        }
    }
}
