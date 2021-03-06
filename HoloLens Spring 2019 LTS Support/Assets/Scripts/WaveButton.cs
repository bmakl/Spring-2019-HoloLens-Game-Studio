﻿using UnityEngine;
using UnityEngine.SceneManagement;
using HoloToolkit.Unity.InputModule;
using GameAnalyticsSDK;

public class WaveButton : MonoBehaviour  {

    [SerializeField] AudioSource startSource; //Set this source from start button canvas if disconnected

    private void Update()
    {
        if (!GameManager.instance.Spawn && GameManager.instance.enemyCount <= 0)//Checks if the wave is finished spawning and if all enemies are dead
        {
            ButtonManager.instance.EnableButton(); //Enables button if passes the if check
            if (GameManager.instance.sendCoinsData)
            {
                AnalyticsManager.CoinsGained();
                GameManager.instance.sendCoinsData = false;
            }
        }
    }

    /// <summary>
    /// Function that is called on the start button to begin the wave
    /// </summary>
    public void StartWave()
    {
        if (SceneManager.GetActiveScene().name == "TutorialScene")
        {
            if (TutorialManager.instance.startWave != true)
            {
                TutorialManager.instance.startWave = true;
                TutorialManager.instance.MoveToUpgradeTower();
            }
            if(TutorialManager.instance.startWave2 != true && TutorialManager.instance.upgradeTower == true)
            {
                TutorialManager.instance.startWave2 = true;
                TutorialManager.instance.MoveToSellTower();
            }
        }
        ButtonManager.instance.DisableButton();
        startSource.Play();
        GameManager.instance.Spawn = true;
        GameManager.instance.waveCount++;
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Wave " + GameManager.instance.waveCount.ToString());
        AnalyticsManager.coinStart = GameManager.instance.coins;
    }
        

}
