using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class moneda : PickableItem
{
    [SerializeField]

    private GameObject ui_puntaje;
    [SerializeField]
    private int valor_moneda;
    private contadorMonedas contador_monedas;

    public void Start()
    {
        contador_monedas = ui_puntaje.GetComponent<contadorMonedas>();
    }

    protected override void Pick(GameObject picker)
    {
        Debug.Log("Recolecccion");
        contador_monedas.ActualizarPuntaje(valor_moneda);
    }
}

