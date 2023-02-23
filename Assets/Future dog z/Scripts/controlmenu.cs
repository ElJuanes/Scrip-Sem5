using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;

public class controlmenu : MonoBehaviour
{
  public void OnpressJugar()
    {
        MMSceneLoadingManager.LoadScene("nivel1");
        SceneManager.LoadScene("nivel1", LoadSceneMode.Single);
    }

    public void Onpressinstrucciones()
    {
        MMSceneLoadingManager.LoadScene("instrucciones");
        SceneManager.LoadScene("instrucciones", LoadSceneMode.Single);
    }

    public void OnpressVolverMenu()
    {
        MMSceneLoadingManager.LoadScene("menu");
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }

     public void OnpressSalir()
    {
        MMSceneLoadingManager.LoadScene("Salir");
    }
}
