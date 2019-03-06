using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class UIUpgrade : MonoBehaviour, IInputClickHandler
{

    public TowerInfo towerinfo;
    public TowerTemplate towertemp;
    public BaseTower basetow;
    int towerUpNum = 0;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (towerUpNum == 0)
        {
            Debug.Log("bruh 1");
            basetow.attackDamage = basetow.upgrade1Damage;
            basetow.radius = basetow.upgrade1Range;
            basetow.attackSpeed = basetow.upgrade1AttackSpeed;
            towerinfo.txt.text = "Damage: " + basetow.attackDamage + " Attack Speed: " + basetow.attackSpeed + " Range: " + basetow.radius;
            towerUpNum++;
        }

        if (towerUpNum == 1) {
            Debug.Log("bruh 2");
            basetow.attackDamage = basetow.upgrade2Damage;
            basetow.radius = basetow.upgrade2Range;
            basetow.attackSpeed = basetow.upgrade2AttackSpeed;
            towerinfo.txt.text = "Damage: " + basetow.attackDamage + " Attack Speed: " + basetow.attackSpeed + " Range: " + basetow.radius;
            towerUpNum++;
        }
    }

}
