﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 2.0f;
    float delta = 0;

    private void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-8, 9);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
