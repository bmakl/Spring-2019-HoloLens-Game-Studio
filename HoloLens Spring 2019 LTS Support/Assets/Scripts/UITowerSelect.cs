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

    [Header("UI Selection")]
    public GameObject SelectedHalo;
    public GameObject[] HaloGroup;
    public static Outline highlight;

    void Start()
    {
        originalScale = transform.localScale;
        //HaloGroup = GameObject.FindGameObjectsWithTag("SelectedHalo");
        foreach (GameObject HaloGroup in HaloGroup)
        {
            HaloGroup.SetActive(false);
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (highlight != null)
        {
            highlight.enabled = false;
            highlight = null;
            highlight = this.GetComponent<Outline>();
            highlight.enabled = true;
        }
        else
        {
            highlight = GetComponent<Outline>();
            highlight.enabled = true;
        }
        Debug.Log("Tower Prefab Selected");
        //Selection Switching
        //HaloGroup = GameObject.FindGameObjectsWithTag("SelectedHalo");
        foreach (GameObject TowerGlow in HaloGroup)
        {
            TowerGlow.SetActive(false);
        }
        //  SelectedHalo.SetActive(true);
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
