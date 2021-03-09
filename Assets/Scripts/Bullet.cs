﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 20f;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    [Range(1, 10)]
    private float damage = 1f;

    [SerializeField]
    private GameObject hitEffect;

    void Start()
    {
        rb.velocity = transform.forward * speed;

    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        var healt = hitInfo.GetComponent<EnemyHealth>();
        if (healt != null)
        {
            healt.TakeDamage(damage);
        }
        
        Destroy(gameObject);
        
    }

}