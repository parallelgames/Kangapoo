﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusStats : BuildingStats
{

    public Cactii cactus;

    private void Awake()
    {
        maxHealth = 100;
        cactus = GetComponentInParent<Cactii>();
    }
     void Update()
    {

        Collider[] hits = Physics.OverlapSphere(transform.position, 2);
        foreach (Collider hit in hits)
        {
            
            //Debug.Log("reeee");
            if ( Input.GetKeyDown(KeyCode.E) && (hit.gameObject.name == "Player") && stats.playerWater < stats.maxWater - 15)
            {
                //Debug.Log("test");
                stats.playerWater += 15;
                cactus.rend.enabled = false;
                cactus.meshCollider.enabled = false;
                Destroy(this);
            }

            
        }
    }



}
