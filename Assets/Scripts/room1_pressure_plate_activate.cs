﻿using UnityEngine;
using System.Collections;

public class room1_pressure_plate_activate : MonoBehaviour
{

    private static ArrayList colliders;
    private BushRotation bush;

    // Use this for initialization
    void Start()
    {
        colliders = new ArrayList();
        GameObject pivit = GameObject.Find("bush-log-rotation-point");
        bush = (BushRotation)pivit.GetComponent(typeof(BushRotation));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player") || col.gameObject.name.Equals("Box"))
        {
            colliders.Add(col.gameObject);
            bush.setActivation(true);
        }

    }

    void OnCollisionExit2D(Collision2D col)
    { 
        if (col.gameObject.tag.Equals("Player") || col.gameObject.name.Equals("Box"))
        {
            colliders.Remove(col.gameObject);
            if (colliders.Count == 0)
            {
                bush.setActivation(false);
            }
        }
    }

}
