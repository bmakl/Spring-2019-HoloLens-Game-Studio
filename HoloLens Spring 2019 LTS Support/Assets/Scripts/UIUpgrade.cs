using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class UIUpgrade : MonoBehaviour, IInputClickHandler
{

    public BaseTower basetow;
    public StoreTowerInfo towerI;
    
    int towerUpNum = 0;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (towerUpNum == 0)
        {
            towerUpNum++;
            Debug.Log("bruh 1");
            basetow.Upgrade1();
            /*
            basetow.attackDamage = basetow.upgrade1Damage;
            basetow.radius = basetow.upgrade1Range;
            basetow.fireRate = basetow.upgrade1fireRate;
            */
        }

        if (towerUpNum == 1) {
            towerUpNum++; //so they cant trigger an upgrade again
            Debug.Log("bruh 2");
            basetow.Upgrade2();
            /*
            basetow.attackDamage = basetow.upgrade2Damage;
            basetow.radius = basetow.upgrade2Range;
            basetow.fireRate = basetow.upgrade2fireRate;
            */
        }
    }

}
