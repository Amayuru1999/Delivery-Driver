using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField]  float destroyDelay = 0.5f;
    bool hasPackage;
    
    void OnCollisionEnter2D(Collision2D other)
    {
       Debug.Log("❌ Collision detected with " + other.gameObject.name);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("📦 Package picked up " + other.gameObject.name);
            hasPackage = true;
            Destroy(other.gameObject,destroyDelay);
            
        }
        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("📦 Package delivered to "+ other.gameObject.name);
            hasPackage=false;
        }
    }
}
