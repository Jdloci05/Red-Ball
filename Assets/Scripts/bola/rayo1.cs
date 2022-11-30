using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayo1 : MonoBehaviour
{
    public float TargetDistance;

    // Update is called once per frame
    
    void Update()
    {

       int layerMask = 1 << 8;

       
        layerMask = ~layerMask;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
            Debug.Log(hit.transform.name);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
}

