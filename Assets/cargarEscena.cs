using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Global
{
    // Static variable that must be initialized at run time.
    public static string playerName;

    // Static constructor is called at most one time, before any
    // instance constructor is invoked or member is accessed.
     static Global()
    {
        playerName = "";
    }
}


public class cargarEscena : MonoBehaviour
{
    public Text nombreJugador;

    private void LoadScene(string sceneName)
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Global.playerName = nombreJugador.text;
        
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        //int("CargarEscenaUpdate");
        /*
        playerName cargar1 = GameObject.FindObjectOfType<playerName>();
        if (cargar1 != null)    
        cargar1.Nombre.text = nombreJugador.text;
        */
    }
}
