using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miusic : MonoBehaviour
{
    public static miusic inst;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Awake()
    {
       

        if(miusic.inst==null)
        {
             miusic.inst = this;
             DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
        
}
