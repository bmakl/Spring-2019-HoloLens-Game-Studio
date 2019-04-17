using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameAnalyticsSDK;

public class TutorialManager : MonoBehaviour
{

    public static TutorialManager instance;
    public float HandTimer;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    //events to track
    public bool basicTowerSelected;
    public GameObject basicTowerSelectedPrompt;
    public GameObject basicTowerSelectedHand;
    public bool basicTowerPlaced;
    public GameObject basicTowerPlacedPrompt;
    public GameObject basicTowerPlacedHand;
    public bool startWave;
    public GameObject startWavePrompt;
    public GameObject startWaveHand;
    public bool upgradeTower;
    public GameObject upgradeTowerPrompt;
    public GameObject upgradeHand;
    public bool startWave2;
    public GameObject startWave2Prompt;
    public GameObject startWave2Hand;
    public bool sellTower;
    public GameObject sellTowerPrompt;
    public GameObject sellTowerHand;
    public bool tutorialComplete;
    public GameObject tutorialCompletePrompt;

    public void MoveToPlaceTower()
    {
        basicTowerSelectedPrompt.SetActive(false);
        basicTowerSelectedHand.SetActive(false);
        basicTowerPlacedPrompt.SetActive(true);
        basicTowerPlacedHand.SetActive(true);
    }

    public void MoveToStartWave()
    {
        basicTowerPlacedPrompt.SetActive(false);
        basicTowerPlacedHand.SetActive(false);
        startWavePrompt.SetActive(true);
        startWaveHand.SetActive(true);
    }

    public void MoveToUpgradeTower()
    {
        startWavePrompt.SetActive(false);
        startWaveHand.SetActive(false);
        upgradeTowerPrompt.SetActive(true);
        upgradeHand.SetActive(true);
    }

    public void MoveToStartWave2()
    {
        upgradeTowerPrompt.SetActive(false);
        upgradeHand.SetActive(false);
        startWave2Prompt.SetActive(true);
        startWave2Hand.SetActive(true);
    }

    public void MoveToSellTower()
    {
        startWave2Prompt.SetActive(false);
        startWave2Hand.SetActive(false);
        sellTowerPrompt.SetActive(true);
        sellTowerHand.SetActive(true);
    }

    public void MoveToFreePlay()
    {
        sellTowerPrompt.SetActive(false);
        sellTowerHand.SetActive(false);
        tutorialCompletePrompt.SetActive(true);
        StartCoroutine(TurnOff());
    }

    private IEnumerator TurnOff()
    {
        yield return new WaitForSeconds(5.0f);
        tutorialCompletePrompt.SetActive(false);
    }
}
