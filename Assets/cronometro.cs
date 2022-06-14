using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cronometro : MonoBehaviour
{
    // Start is called before the first frame update

    float tiempo;

    public Text mostrarhora;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        mostrarhora.text = "" + tiempo;

    }
}
