using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class moneda : PickableItem
{
    [SerializeField]
    private GameObject game_object;

    private GameObject ui_puntaje;
    [SerializeField]
    private int valor_moneda;
    private contadorMonedas contador_monedas;

    public void Start()
    {
        contador_monedas = ui_puntaje.GetComponent<contadorMonedas>();
    }

    public void Ocultar()
    {
        game_object.SetActive(false);
    }

    public void Mostrar()
    {
        game_object.SetActive(true);
    }

    protected override void Pick(GameObject picker)
    {
        //Debug.Log("Recolecccion");
        contador_monedas.ActualizarPuntaje(valor_moneda);
    }
}

