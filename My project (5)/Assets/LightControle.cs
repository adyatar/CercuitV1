using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControle : MonoBehaviour
{
   public Light mylight;
    void Start()
    {
        mylight = GetComponent<Light>();
    }
    void Update()
    {
        
    }
    public void allumer()
    { 
        mylight.enabled = true;
    }
    public void tfido()
    {
        mylight.enabled = false;
       
    }
}
