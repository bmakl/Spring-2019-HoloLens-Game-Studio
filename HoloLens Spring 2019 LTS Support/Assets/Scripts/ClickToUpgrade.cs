using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class ClickToUpgrade : MonoBehaviour, IInputClickHandler {

    private static Outline outlineUpgrade;
    public GameObject currentTower;
    public string description;


    // Use this for initialization
    void Start ()
    {

        switch (currentTower.tag)
        {
            case "Basic Tower":
                description = "Medium-ranged tower that offers balanced damage and fire rate";
                break;

            case "Powerful Tower":
                description = "Extraordinary tower with fantastic range and power";
                break;

            case "Melee Tower":
                description = "Close-range tower with tremendous damage";
                break;

            case "Debuff Tower":
                description = "Mysterious tower that slows enemies as they pass";
                break;
            default:
                return;
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {



        GameManager.instance.lastUpgrade = this.tag;

        if (outlineUpgrade)
        {
            outlineUpgrade.enabled = false;
            outlineUpgrade = this.GetComponentInChildren<Outline>();
            outlineUpgrade.enabled = true;
        }
        else
        {
            outlineUpgrade = this.GetComponentInChildren<Outline>();
            outlineUpgrade.enabled = true;
        }


        if (!currentTower.CompareTag("Melee Tower"))
        {
            UpgradeManager.instance.currentTower = currentTower.GetComponent<BaseTower>();
            UpgradeManager.instance.towerToDelete = this.gameObject.GetComponentInParent<Transform>().gameObject;
            UpgradeManager.instance.displayInfo(currentTower, description);
            //UpgradeManager.instance.spawnObject();
            Debug.Log("UI");
        }
        else if (currentTower.CompareTag("Melee Tower"))
        {
            UpgradeManager.instance.currentMelee = currentTower.GetComponent<MeleeTower>();
            UpgradeManager.instance.towerToDelete = this.gameObject.GetComponentInParent<Transform>().gameObject;
            UpgradeManager.instance.displayInfo(currentTower, description);
            //UpgradeManager.instance.spawnObject();
            Debug.Log("UI");
        }
        

    }
}
