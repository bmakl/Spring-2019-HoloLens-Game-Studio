using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class UITowerSelect : MonoBehaviour, IInputClickHandler
{
    public GameObject tower;
    public GameObject[] nodes;
    public int towerID;

    void Start()
    {

    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("Tower Prefab Selected");
        TowerManager.towerNumber = towerID;
    }
}
