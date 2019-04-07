using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.SceneManagement;
using GameAnalyticsSDK;

public class TowerSpawn : MonoBehaviour, IInputClickHandler
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

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (nodeEnabled)
        {
            if (towerPrefab != null) //If towerprfab is set to something an object was spawned on this node
            {
                Debug.Log("Already Turret On Node");
                return;
            }
            PlaceTower();
            Debug.Log(towerPrefab.tag);
            if (towerPrefab.CompareTag("Melee Tower") && GameManager.instance.meleeCost <= GameManager.instance.coins) //Checks if enough money for tower
            {
                GameObject instantiateTower = Instantiate(towerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);//Spawns object
                instantiateTower.GetComponentInChildren<MeleeTower>().node = this.transform.gameObject;//sets the node hte towerr is on to this node
                GameManager.instance.coins -= GameManager.instance.meleeCost;//takes away the coins from the cost of this tower
                GameAnalytics.NewResourceEvent(GAResourceFlowType.Sink, "Coins", GameManager.instance.meleeCost, "MeleeTower", "MeleeTower");//Analytics event
            }
            else if (towerPrefab.CompareTag("Basic Tower") && GameManager.instance.baseCost <= GameManager.instance.coins)
            {
                if(SceneManager.GetActiveScene().name == "TutorialScene")
                {
                    if (TutorialManager.instance.basicTowerPlaced != true)
                    {
                        TutorialManager.instance.basicTowerPlaced = true;
                        TutorialManager.instance.MoveToStartWave();
                    }
                } 
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

    /// <summary>
    /// This switch handles the placement of towers by indexing the array and setting the tower based on what was set in the ui towers
    /// </summary>
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

}
