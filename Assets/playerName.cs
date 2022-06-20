using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class playerName : MonoBehaviour
{
    cargarEscena cargar;
    
    // Start is called before the first frame update
    public Text Nombre;
    

    void Start()
    {

        Nombre.text = Global.playerName;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
