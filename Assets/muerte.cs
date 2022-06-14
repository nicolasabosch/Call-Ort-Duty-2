using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muerte : MonoBehaviour
{
    public GameObject zombie;
    float tiempo = 5;

    int contador_muerte=0;
    int instanciar;
    public Text muerte_contable;


    

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        contador_muerte++;
    }

    

    // Update is called once per frame
    void Update()
    {


        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
        }

       
            if (tiempo <= 0)
            {
                Instantiate(zombie, new Vector3(5.1f, 2.87f, -2.52f), new Quaternion());
                tiempo = 5;
                instanciar++;
                
        }
        muerte_contable.text = contador_muerte.ToString();

    }
}
