using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("oops!");
    }
     private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package"){
            hasPackage = true;
        }
        if(other.tag == "Customer" && hasPackage){
            hasPackage = false;
        }
    }
}
