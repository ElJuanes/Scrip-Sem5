using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using MoreMountains.CorgiEngine;
//using MoreMountains.Tools;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
  public void OnpressJugar()
    {
        //MMSceneLoadingManager.LoadScene("Nivel 2.1");
        SceneManager.LoadScene("PixelLevel", LoadSceneMode.Single);
    }

    public void OnpressJugar2()
    {
        //MMSceneLoadingManager.LoadScene("nivel1");
        SceneManager.LoadScene("nivel1", LoadSceneMode.Single);
    }


    public void Onpressinstrucciones()
    {
        //MMSceneLoadingManager.LoadScene("Instrucciones");
        SceneManager.LoadScene("Instrucciones", LoadSceneMode.Single);
    }

    public void OnpressVolverMenu()
    {
        //MMSceneLoadingManager.LoadScene("menu");
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }

     public void OnpressSalir()
    {
        //MMSceneLoadingManager.LoadScene("Salir");
    }
}
