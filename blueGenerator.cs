﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueGenerator : MonoBehaviour
{
    public GameObject blueprefab;
    float span = 1.6f;
    float delta = 0;


    void Start()
    {
        
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(blueprefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
