using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Aleatorio : MonoBehaviour
{
    [SerializeField]
    private List<Enemigo> enemi;
    private int[] indices = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};

    void Start()
    {
        Shuffle();
        OcultarEnemigo();
        MostrarEnemigo(10);
    }

    public void MostrarEnemigo(int total)
    {
        int indice_enemigo;
        if (total >= 0 && total < enemi.Count)
        {
            for (int i = 0; i < total; i++)
            {
                indice_enemigo = indices[i];
                if (indice_enemigo < enemi.Count)
                {
                    enemi[indice_enemigo].Mostrar();
                }
            }
        }
    }

    public void OcultarEnemigo()
    {
        for (int i = 0; i < enemi.Count; i++)
        {
            enemi[i].Ocultar();
        }
    }

    public void Shuffle()
    {
        for (int t = 0; t < indices.Length; t++)
        {
            int tmp = indices[t];
            int r = Random.Range(t, indices.Length);
            indices[t] = indices[r];
            indices[r] = tmp;
        }
    }
}
