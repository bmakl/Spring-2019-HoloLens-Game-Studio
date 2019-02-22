using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class UITowerSelect : MonoBehaviour, IInputHandler, IInputClickHandler
{
    public GameObject tower;
    public GameObject[] nodes;
    [SerializeField] private int towerID;

    void Start()
    {

    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("nice click");
        TowerManager.towerNumber = towerID;
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
