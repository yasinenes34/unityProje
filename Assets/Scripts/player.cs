﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class player : MonoBehaviour
{
    public int Max = 100;
    public int currentHp;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHp = Max;
        healthBar.SetmaxHealth(Max);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHp -= damage;
        healthBar.SetHealth(currentHp);
    }
}
