using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;

public class AnalyticsManager : MonoBehaviour
{

    public static AnalyticsManager instance;
    public float coinStart;
    public float coinEnd;
    public float coinAggregate;
    public float coinEarnedByWave;
    public float healthStart;
    public float healthEnd;
    public float enemiesKilledInWave;
    public float enemiesKilled;
    public float towersPlaced;
    public float towersPlacedInWave;
    public int waveNum;
    public int lastWaveCompleted;

    public void Awake()
    {
        GameAnalytics.Initialize();
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Destroy(this);
        }
    }

    public void CoinsGained()
    {
        float difference = GameManager.instance.coins - coinStart;
        GameAnalytics.NewResourceEvent(GAResourceFlowType.Source, "Coins", difference, "Coins", "Coin");
    }

}
