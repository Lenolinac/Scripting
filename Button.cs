using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator button;
    public Animator toOpen;
    
    void Start()
    {
        button.enable = false;
    }

    private void OnTriggerEnter(Collider object)
    {
        button.enabled = true;
        toOpen.enabled = true;
    }
}
