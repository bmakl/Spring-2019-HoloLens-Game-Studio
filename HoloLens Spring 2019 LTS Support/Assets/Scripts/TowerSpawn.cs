using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class TowerSpawn : MonoBehaviour, IInputHandler, IInputClickHandler
{
    public GameObject spawnPoint;
    //[HideInInspector]
    public GameObject turretToBuild;
    public GameObject towerPrefab;
    public bool nodeEnabled = true;
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
            Instantiate(towerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
        }
        else
        {

        }
    }private void PlaceTower()
    {
        switch (TowerManager.towerNumber)
        {
            case 0:
                towerPrefab = Towers[0];
                break;

            case 1:
                towerPrefab = Towers[1];
                break;
            case 2:
                towerPrefab = Towers[2];
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
