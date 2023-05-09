using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;


public class Controlmuerte : MonoBehaviour, MMEventListener<CorgiEngineEvent>,
                                            MMEventListener<MMDamageTakenEvent>{



    [SerializeField]

    private List <GameObject> corazones;

    private int vidas;



    [SerializeField]



   

    public void Start(){
        vidas = corazones.Count;
    }

    public void OnMMEvent(CorgiEngineEvent e)
    {
        if (e.EventType == CorgiEngineEventTypes.PlayerDeath)
        {
            
            if (vidas == 0) 
            {
                Debug.Log("Game Over");
                SceneManager.LoadScene("menu", LoadSceneMode.Single);
            }
        }

        Debug.Log(vidas);
        Debug.Log(e.EventType);
    }


   
    public virtual void OnMMEvent(MMDamageTakenEvent e)

    {
        //Debug.Log("Daño");
        //Debug.Log(" Daño causado " e.DamageCaused);
        //Debug.Log(" Salud afectada " e.Instigator.tag);
        //Debug.Log(" Salud Actual " e.CurrentHealth);
    }

    void OnEnable()
    {
        this.MMEventStartListening<CorgiEngineEvent>();
        this.MMEventStartListening<MMDamageTakenEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<CorgiEngineEvent>();
        this.MMEventStopListening<MMDamageTakenEvent>();
    }

}