using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista : MonoBehaviour

{
    private List<Moneda> coins;
    private int[]indices = {0,1,2,3,4,5,6,7,8,9};

    void Start(){
        Shuffle();
        OcultarMonedas();
        MostrarMonedas(1);
    }

    public void MostrarMonedas(int total){
        int indice_Moneda;
        if(total>=0 && total<coins.count)
        {
            for(int i=0;i<total;i++){
                indice_Moneda = indices[i];
                coins[indice_Moneda].Mostrar();
            }
        }
    }

    public void OcultarMonedas()
    {
        for(int t=0; t < indices.Length; t++)
        {
            int tmp = indices[t];
            int r = Random.Range(t, indices.Length);
            indices[t] = indices[r];
            indices[r] = tmp;
        }
    }
}
    
