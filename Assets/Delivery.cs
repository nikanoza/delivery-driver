using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("oops!");
    }
     private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Package"){
            Debug.Log("pick up package");
        }
        if(other.tag == "Customer"){
            Debug.Log("package delivered");
        }
    }
}
