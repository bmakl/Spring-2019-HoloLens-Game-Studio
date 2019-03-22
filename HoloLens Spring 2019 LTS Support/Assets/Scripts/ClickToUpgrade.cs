using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class ClickToUpgrade : MonoBehaviour, IInputClickHandler {

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
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInputClicked(InputClickedEventData eventData)
    {
        UpgradeManager.instance.currentTower = currentTower.GetComponent<BaseTower>();
        UpgradeManager.instance.towerToDelete = this.gameObject.GetComponentInParent<Transform>().gameObject;
        UpgradeManager.instance.displayInfo(currentTower, description);
        UpgradeManager.instance.spawnObject();
        Debug.Log("UI");
    }
}
