using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using DG.Tweening;

public class UITowerSelect : MonoBehaviour, IInputClickHandler,IFocusable
{
    [Header("Tower Info")]
    public GameObject tower;
    public GameObject[] nodes;
    public int towerID;
    private Vector3 originalScale;

    [Header("Tween Info")]
    [SerializeField] float tweenAmmount;
    [SerializeField] float tweenDuration;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("Tower Prefab Selected");
        TowerManager.towerNumber = towerID;
    }

    public void OnFocusEnter()
    {
        TweenManager.instance.TweenScale(this.transform,tweenAmmount,tweenDuration);
    }

    public void OnFocusExit()
    {
        TweenManager.instance.Descale(this.transform, originalScale, tweenDuration);
    }
}
