using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class controlmenu : MonoBehaviour
{
  public void OnpressJuegar()
    {
        MMSceneLoadingManager.LoadScene("nivel1");
    }

    public void Onpressinstrucciones()
    {
        MMSceneLoadingManager.LoadScene("instrucciones");
    }

     public void OnpressSalir()
    {
        MMSceneLoadingManager.LoadScene("Salir");
    }
}
