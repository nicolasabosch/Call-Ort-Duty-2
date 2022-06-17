using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crear_zombie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject zombie;
    float tiempo = 5;


    void Start()
    {
        Debug.Log(zombie);
        GameObject zombiE2 = zombie;

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
            //zombie = new GameObject() ;
            Debug.Log(tiempo);

            tiempo = 5;
            //Instantiate(zombie, new Vector3(5.1f, 2.87f, -2.52f), new Quaternion());
            Instantiate(zombie, new Vector3(0f, 0f, 0f), new Quaternion());

        }
        
    }
}
