﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRandom : MonoBehaviour
{
    public Transform spawnPoint;

    public GameObject[] prefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab[Random.Range(0, 4)], spawnPoint.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}