using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contadorMonedas : MonoBehaviour
{
    [SerializeField]
    private TMP_Text txt_contador_monedas;
    private int contador_monedas;

    public int CantidadMonedasRecolectadas()
    {
        return contador_monedas;
    }

    public void ActualizarPuntaje(int valor)
    {
        contador_monedas += valor;
        ActualizarValorUI();
    }


    

    public void ActualizarValorUI()
    {
        txt_contador_monedas.text = "" + contador_monedas;
    }
    
    
}
