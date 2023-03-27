using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroAyuda2 : MonoBehaviour
{
    [SerializeField]
    private GameObject muro;
    private Contadorllaves contador_llaves;

    public void Start()
    {
        contador_llaves = this.transform.parent.GetComponent<Contadorllaves>();
        Debug.Log(contador_llaves);

    }

    public void Update()
    {
        if (contador_llaves.CantidadllavesRecolectadas() == 1) 
        {
            CambiarEstado(false);
        }
    
    }

    public void CambiarEstado(bool estado)
    {
        muro.SetActive(estado);
      
    }
}