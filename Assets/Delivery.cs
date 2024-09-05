using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
       Debug.Log("❌ Collision detected with " + other.gameObject.name);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("📦 Package picked up " + other.gameObject.name);
            
        }
        if(other.tag == "Customer")
        {
            Debug.Log("📦 Package delivered to "+ other.gameObject.name);
        }
    }
}
