using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class TowerStats : MonoBehaviour {

    public Text towerInfo;
    BaseTower baseTower;

    void Start()
    {
        towerInfo.text = "";
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        towerInfo.text = "Damage: " + baseTower.attackDamage + " Attack Speed: " + baseTower.attackSpeed + " Range: " + baseTower.radius;
    }
}
