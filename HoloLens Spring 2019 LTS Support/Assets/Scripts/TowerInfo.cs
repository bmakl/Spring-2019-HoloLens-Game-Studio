using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class TowerInfo : MonoBehaviour, IInputClickHandler
{

    public Text txt;
    public BaseTower baseTower;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        BaseTower stats = GazeManager.Instance.HitInfo.transform.GetComponent<BaseTower>();
        txt.text = "Damage: " + stats.attackDamage + " Attack Speed: " + stats.attackSpeed + " Range: " + stats.radius;
    }
}