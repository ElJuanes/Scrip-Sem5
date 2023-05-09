using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class controlinmunidad : MonoBehaviour, MMEventListener<MMGameEvent>
{
    // Start is called before the first frame update

    private Health health;

    void Start()
    {
        health = this.GetComponent<Health>();
    }

    public virtual void OnMMEvent(MMGameEvent e)
    {
        Debug.Log(e.EventName);

        if (e.EventName == "CarneEvent")
        {
            health.DamageDisabled();
        }
    }

    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }

    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }
}