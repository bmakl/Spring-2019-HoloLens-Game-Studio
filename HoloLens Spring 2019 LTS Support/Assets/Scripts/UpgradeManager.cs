using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;

public class UpgradeManager : MonoBehaviour{

    public static UpgradeManager instance;
    public BaseTower currentTower;
    public Text damage;
    public Text fireRate;
    public Text radius;
    public Text description;
    public Button sell;
    public Button upgrade;
    public GameObject displayTile;
    public GameObject upgradeCanvas;
    public Transform spawnPoint;
    public GameObject towerToDelete;
    public string desc;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }


    public void spawnObject()
    {
        GameObject towerToDisplay = Instantiate(towerToDelete, spawnPoint.position, spawnPoint.rotation);
    }

    public void displayInfo(GameObject myTower, string _description)
    {
        desc = _description;
        damage.text = "Damage: " + Mathf.RoundToInt(myTower.GetComponent<BaseTower>().attackDamage);
        fireRate.text = "Fire rate: " + Mathf.RoundToInt(myTower.GetComponent<BaseTower>().fireRate);
        radius.text ="Radius: " + Mathf.RoundToInt(myTower.GetComponent<BaseTower>().radius);
        description.text = "Description: " + _description;
        //towerToDisplay.GetComponent<BaseTower>().enabled = false;
    }

    public void SellTower()
    {
        Debug.Log("sell tower");
        GameManager.instance.coins += currentTower.price;
        currentTower.node.GetComponent<TowerSpawn>().towerPrefab = null;
        Destroy(towerToDelete);
        Debug.Log(currentTower.transform.position);
    }

    public void UpgradeTower()
    {
        currentTower.Upgrade();
        displayInfo(currentTower.gameObject, desc);
    }


}
