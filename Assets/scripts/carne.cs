using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;


public class carne : MonoBehaviour, MMEventListener<PickableItemEvent>
{


    // Start is called before the first frame update
    void Start()
    {

    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Debug.Log(this.gameObject.tag);
        if (this.gameObject.tag == "vida")
        {
            MMEventManager.TriggerEvent(new MMGameEvent("CarneEvent"));
        }
    }

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }
}