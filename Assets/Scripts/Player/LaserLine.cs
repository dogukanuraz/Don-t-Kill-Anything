﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserLine : MonoBehaviour
{
    private LineRenderer lr;
    [Space]
    [SerializeField]
    Vector3 correctionVector;
    LayerMask layermask;
    [SerializeField] Transform raycastPoint;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.enabled = true;
        lr.useWorldSpace = false;
        layermask = LayerMask.GetMask("Player");
    }
    
    void Update()
    {
        lr.SetPosition(0, correctionVector); 
        RaycastHit hit;
        Debug.DrawRay(raycastPoint.position, transform.forward*1000f);
        if (Physics.Raycast(raycastPoint.position, transform.forward, out hit,layermask))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, ((new Vector3(0f,0f,hit.distance/4f))+correctionVector) );
            }
        }
        else lr.SetPosition(1, Vector3.forward *1000f + correctionVector);
    }
}
