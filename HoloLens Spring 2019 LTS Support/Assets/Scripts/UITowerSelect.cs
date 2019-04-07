using HoloToolkit.Unity.InputModule;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UITowerSelect : MonoBehaviour, IInputClickHandler, IFocusable
{
    [Header("Tower Info")]
    public GameObject tower;
    public GameObject[] nodes;
    public int towerID;
    private Vector3 originalScale;
    private bool canAfford = false;

    [Header("Tween Info")]
    [SerializeField] float tweenAmmount;
    [SerializeField] float tweenDuration;

    [Header("UI Selection")]
    public static Outline highlight;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (this.CompareTag("Basic Tower") && GameManager.instance.baseCost > GameManager.instance.coins)
        {
            canAfford = false;
            Outline thisHighlight = GetComponent<Outline>();
            thisHighlight.enabled = true;
            thisHighlight.OutlineColor = Color.red;
        }
        else if (this.CompareTag("Melee Tower") && GameManager.instance.meleeCost > GameManager.instance.coins)
        {
            canAfford = false;
            Outline thisHighlight = GetComponent<Outline>();
            thisHighlight.enabled = true;
            thisHighlight.OutlineColor = Color.red;
        }
        else if (this.CompareTag("Powerful Tower") && GameManager.instance.powerfulCost > GameManager.instance.coins)
        {
            canAfford = false;
            Outline thisHighlight = GetComponent<Outline>();
            thisHighlight.enabled = true;
            thisHighlight.OutlineColor = Color.red;
        }
        else if (this.CompareTag("Debuff Tower") && GameManager.instance.debuffCost > GameManager.instance.coins)
        {
            canAfford = false;
            Outline thisHighlight = GetComponent<Outline>();
            thisHighlight.enabled = true;
            thisHighlight.OutlineColor = Color.red;
        }

        if (this.CompareTag("Basic Tower") && GameManager.instance.baseCost < GameManager.instance.coins && !canAfford)
        {
            canAfford = true;
            Outline thisHighlight = GetComponent<Outline>();
            thisHighlight.enabled = false;
        }
        else if (this.CompareTag("Melee Tower") && GameManager.instance.meleeCost < GameManager.instance.coins && !canAfford)
        {
            canAfford = true;
            Outline thisHighlight = GetComponent<Outline>();
            thisHighlight.enabled = false;
        }
        else if (this.CompareTag("Powerful Tower") && GameManager.instance.powerfulCost < GameManager.instance.coins && !canAfford)
        {
            canAfford = true;
            Outline thisHighlight = GetComponent<Outline>();
            thisHighlight.enabled = false;
        }
        else if (this.CompareTag("Debuff Tower") && GameManager.instance.debuffCost < GameManager.instance.coins && !canAfford)
        {
            canAfford = true;
            Outline thisHighlight = GetComponent<Outline>();
            thisHighlight.enabled = false;
        }

    }

    public void OnInputClicked(InputClickedEventData eventData)
    {

        if (highlight != null)//Checks if the object is highlighted
        {
            highlight.enabled = false;
            highlight = this.GetComponent<Outline>();
            highlight.OutlineColor = Color.cyan;
            highlight.enabled = true;
        }
        else //if it is not 
        {
            highlight = GetComponent<Outline>();
            highlight.OutlineColor = Color.cyan;
            highlight.enabled = true;
            if(SceneManager.GetActiveScene().name == "TutorialScene")
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
        TweenManager.instance.TweenScale(this.transform, tweenAmmount, tweenDuration);//When you look at the object it tweens bigger
    }

    public void OnFocusExit()
    {
        TweenManager.instance.Descale(this.transform, originalScale, tweenDuration);//Sets object back to it's original size after you look away
    }
}
