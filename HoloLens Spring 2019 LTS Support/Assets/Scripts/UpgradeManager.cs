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
    private GameObject towerUI;


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

        if (towerUI != null)
        {
            Destroy(towerUI);
        }
        GameObject towerToDisplay = Instantiate(towerToDelete, spawnPoint.position, spawnPoint.rotation);
        towerUI = towerToDisplay;
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
    /// <summary>
    /// Disables Sell Button on upgrade cavnas
    /// </summary>
    public void DisableUpgradeButton()
    {
        upgrade.interactable = false;
    }
    /// <summary>
    /// Enables Button on upgrade canvas
    /// </summary>
    public void EnableUpgradeButton()
    {
        upgrade.interactable = true;
    }


}
