using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroV : MonoBehaviour
{
    [SerializeField]
    private GameObject muro;
    private contadorMonedas contador_monedas;
  

    public void Start()
    {
        contador_monedas = this.transform.parent.GetComponent<contadorMonedas>();
        Debug.Log(contador_monedas);
    }

    public void Update()
    {
        if (contador_monedas.CantidadMonedasRecolectadas() == 180) 
        {
            CambiarEstado(false);
        }
    }

    public void CambiarEstado(bool estado)
    {
        muro.SetActive(estado);
    }
}