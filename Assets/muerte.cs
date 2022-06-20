using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muerte : MonoBehaviour
{
    

    
    public Text txtMuertes;
    

    public GameObject zombie;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name== "FPSController")
        {
            return;
        }
        
        Destroy(gameObject);

        txtMuertes.text = txtMuertes.text.Replace("Kills:", "").Trim();
        txtMuertes.text = "Kills:" + (int.Parse (txtMuertes.text) + 1).ToString();
        
        

    }

    

    // Update is called once per frame
    void Update()
    {


      //  muerte_contable.text = contador_muerte.ToString();

    }
}
