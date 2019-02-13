using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class TowerInfo : MonoBehaviour {

    public Text txt;
    public BaseTower baseTower;

    void OnFocusEnter()
    {
        StartCoroutine(showInfo());
    }

    void OnFocusExit()
    {
        StartCoroutine(hideInfo());
    }

    IEnumerator showInfo()
    {
        yield return new WaitForSeconds(2);
        txt.text = "Damage: " + baseTower.attackDamage + " Radius: " + baseTower.radius + " Fire rate: " + baseTower.attackSpeed;
    }

    IEnumerator hideInfo()
    {
        txt.text = " ";
        yield return new WaitForSeconds(0);
    }
}
