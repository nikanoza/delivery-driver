using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingsToFollow; 
    void Update()
    {
        transform.position =  thingsToFollow.transform.position + new Vector3(0,0,-10);
    }
}
