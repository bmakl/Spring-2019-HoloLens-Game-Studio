using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class StoreTowerInfo : MonoBehaviour, IInputClickHandler
{
    public Text txt;
    public BaseTower baseT;
    public float dmg, range, atkspeed;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        BaseTower baseT = GazeManager.Instance.HitInfo.transform.GetComponent<BaseTower>();
        dmg = baseT.attackDamage;
        range = baseT.radius;
        atkspeed = baseT.attackSpeed;
        txt.text = "Damage: " + dmg + " Attack Speed: " + atkspeed + " Range: " + range;
    }
}   