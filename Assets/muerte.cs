using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muerte : MonoBehaviour
{
    

    int contador_muerte=0;
    public Text muerte_contable;

    public GameObject zombie;
    

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        contador_muerte++;
        muerte_contable.text = contador_muerte.ToString();
    }

    

    // Update is called once per frame
    void Update()
    {


        muerte_contable.text = contador_muerte.ToString();

    }
}
