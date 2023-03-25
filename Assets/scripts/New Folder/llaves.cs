using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class llaves : PickableItem
{
    [SerializeField]
    private GameObject ui_puntaje;
    [SerializeField]
    private int valor_llaves;
    private Contadorllaves contador_llaves;

    public void Start()
    {
        contador_llaves = ui_puntaje.GetComponent<Contadorllaves>();
    }

    protected override void Pick(GameObject picker)
    {
        Debug.Log("Recolecccion");
        contador_llaves.ActualizarPuntaje(valor_llaves);
    }
}
