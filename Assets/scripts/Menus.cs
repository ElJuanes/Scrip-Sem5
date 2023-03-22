using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using MoreMountains.CorgiEngine;
//using MoreMountains.Tools;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
  public void OnpressJugar()
    {
        //MMSceneLoadingManager.LoadScene("nivel1");
        SceneManager.LoadScene("PixelLevel", LoadSceneMode.Single);
    }

    public void Onpressinstrucciones()
    {
        //MMSceneLoadingManager.LoadScene("instrucciones");
        SceneManager.LoadScene("instrucciones", LoadSceneMode.Single);
    }

    public void OnpressVolverMenu()
    {
        //MMSceneLoadingManager.LoadScene("menu");
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

     public void OnpressSalir()
    {
        //MMSceneLoadingManager.LoadScene("Salir");
    }
}
