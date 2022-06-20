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
           
        if (collision.gameObject.name.ToLower().IndexOf("zombie") > -1) {
            vivo = false;
            Cursor.lockState= CursorLockMode.None;
            Cursor.visible = true;
            

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




        if (vivo == false)
        {
            
            vivo = true;
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

                

            
        }
    }
}
