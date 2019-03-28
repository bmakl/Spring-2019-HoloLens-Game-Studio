﻿using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using GameAnalyticsSDK;

public class TowerSpawn : MonoBehaviour, IInputHandler, IInputClickHandler
{
    public GameObject spawnPoint;
    //[HideInInspector]
    public GameObject turretToBuild;
    public GameObject towerPrefab;
    public bool nodeEnabled = true;
    [Header("Available Towers")]
    public GameObject[] Towers;

    Renderer rend;
    public void Start()
    {
        rend = GetComponent<MeshRenderer>();

        if (!nodeEnabled)
        {
            rend.material.color = Color.red;
        }

    }

   /* public void SpawnWave(int Pumpkins, int Skeletons, int Ghosts)
    {
        //Pumpkin Spawner
        for(int i = 0; i<Pumpkins-1;i++)
        {
            ins
        }
    }*/


    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (nodeEnabled)
        {
            if (towerPrefab != null)
            {
                Debug.Log("Already Turret On Node");
                return;
            }
            PlaceTower();
            Debug.Log(towerPrefab.tag);
            if (towerPrefab.CompareTag("Melee Tower") && GameManager.instance.meleeCost <= GameManager.instance.coins)
            {
                Debug.Log(towerPrefab.gameObject.GetComponentInChildren<MeleeTower>().price);
                GameObject instantiateTower = Instantiate(towerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
                instantiateTower.GetComponentInChildren<MeleeTower>().node = this.transform.gameObject;
                GameManager.instance.coins -= GameManager.instance.meleeCost;
                GameAnalytics.NewResourceEvent(GAResourceFlowType.Sink, "Coins", GameManager.instance.meleeCost, "MeleeTower", "MeleeTower");
            }
            else if (towerPrefab.CompareTag("Basic Tower") && GameManager.instance.baseCost <= GameManager.instance.coins)
            {
                GameObject instantiateTower = Instantiate(towerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
                instantiateTower.GetComponentInChildren<BaseTower>().node = this.transform.gameObject;
                GameManager.instance.coins -= GameManager.instance.baseCost;
                GameAnalytics.NewResourceEvent(GAResourceFlowType.Sink, "Coins", GameManager.instance.baseCost, "BasicTower", "BasicTower");
            }
            else if (towerPrefab.CompareTag("Powerful Tower") && GameManager.instance.powerfulCost <= GameManager.instance.coins)
            {
                GameObject instantiateTower = Instantiate(towerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation * Quaternion.Euler(0, 90, 0)); ;
                instantiateTower.GetComponentInChildren<BaseTower>().node = this.transform.gameObject;
                GameManager.instance.coins -= GameManager.instance.powerfulCost;
                GameAnalytics.NewResourceEvent(GAResourceFlowType.Sink, "Coins", GameManager.instance.powerfulCost, "PowerfulTower", "Powerful");
            }
            else if (towerPrefab.CompareTag("Debuff Tower") && GameManager.instance.debuffCost <= GameManager.instance.coins)
            {
                GameObject instantiateTower = Instantiate(towerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
                instantiateTower.GetComponentInChildren<BaseTower>().node = this.transform.gameObject;
                GameManager.instance.coins -= GameManager.instance.debuffCost;
                GameAnalytics.NewResourceEvent(GAResourceFlowType.Sink, "Coins", GameManager.instance.debuffCost, "DebuffTower", "Debuff");
            }
            else
            {
                towerPrefab = null;
            }
           
        }
    }

    private void PlaceTower()
    {
        //Assigns Tower Prefab
        switch (TowerManager.towerNumber)
        {
            case 0:
                //Base Tower
                towerPrefab = Towers[0];
                break;

            case 1:
                //Melee Tower
                towerPrefab = Towers[1];
                break;
            case 2:
                //Debuff Tower
                towerPrefab = Towers[2];
                break;
            case 3:
                //Powerful Tower
                towerPrefab = Towers[3];
                break;
        }
    }   

    public void OnInputDown(InputEventData eventData)
    {
        Debug.Log("down click");
    }

    public void OnInputUp(InputEventData eventData)
    {
        Debug.Log("up click");
    }
}
