using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public static Outline highlight;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
 
        if (highlight != null)//Checks if the object is highlighted
        {
            highlight.enabled = false;
            highlight = this.GetComponent<Outline>();
            highlight.enabled = true;
        }
        else //if it is not 
        {
            highlight = GetComponent<Outline>();
            highlight.enabled = true;
            if(SceneManager.GetActiveScene().name == "Tutorial Scene")
            {
                if (TutorialManager.instance.basicTowerSelected != true)
                {
                    TutorialManager.instance.basicTowerSelected = true;
                    TutorialManager.instance.MoveToPlaceTower();
                }
            }
            
        }
        TowerManager.towerNumber = towerID;
    }

    public void OnFocusEnter()
    {
        TweenManager.instance.TweenScale(this.transform,tweenAmmount,tweenDuration);//When you look at the object it tweens bigger
    }

    public void OnFocusExit()
    {
        TweenManager.instance.Descale(this.transform, originalScale, tweenDuration);//Sets object back to it's original size after you look away
    }
}
