using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lightscript : MonoBehaviour
{
    Light mylight;
    private void Start()
    {
        mylight = GetComponent<Light>();
    }
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            mylight.enabled = !mylight.enabled;
        }
    }
}


