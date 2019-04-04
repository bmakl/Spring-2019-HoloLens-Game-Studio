using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;

public class AnalyticsManager : MonoBehaviour
{

    [HideInInspector] public float coinStart;

    // Start is called before the first frame update
    void Start()
    {
        GameAnalytics.Initialize();

        GameAnalytics.NewDesignEvent("test:Started Game");
        DontDestroyOnLoad(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CoinsGained()
    {
        float difference = GameManager.instance.coins - coinStart;
        GameAnalytics.NewResourceEvent(GAResourceFlowType.Source, "Coins", difference, "Coins", "Coin");
    }
}

