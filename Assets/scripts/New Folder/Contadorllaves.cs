using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contadorllaves : MonoBehaviour
{
    [SerializeField]
    private TMP_Text txt_contador_llaves;
    private int contador_llaves;

    public int CantidadllavesRecolectadas()
    {
        return contador_llaves;
    }

    public void ActualizarPuntaje(int valor)
    {
        contador_llaves += valor;
        ActualizarValorUI();
    }


    

    public void ActualizarValorUI()
    {
        txt_contador_llaves.text = "" + contador_llaves;
    }
    
    
}