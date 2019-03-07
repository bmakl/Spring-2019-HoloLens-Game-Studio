using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class TowerInfo : MonoBehaviour, IInputClickHandler
{

    public TextMesh txt;
    public BaseTower baseTower;
    public GameObject upgradeSection;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        upgradeSection.SetActive(true);
        BaseTower stats = GazeManager.Instance.HitInfo.transform.GetComponent<BaseTower>();
        txt.text = "Damage: " + stats.attackDamage + " Attack Speed: " + stats.fireRate + " Range: " + stats.radius;
    }

    public void updateInfo()
    {
        BaseTower stats = GazeManager.Instance.HitInfo.transform.GetComponent<BaseTower>();
        txt.text = "Damage: " + stats.attackDamage + " Attack Speed: " + stats.fireRate + " Range: " + stats.radius;
    }
}