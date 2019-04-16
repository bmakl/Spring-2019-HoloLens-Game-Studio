using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;

public class AnalyticsManager : MonoBehaviour
{

    [HideInInspector] public static float coinStart;

    private static AnalyticsManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameAnalytics.Initialize();

        GameAnalytics.NewDesignEvent("test:Started Game");
        DontDestroyOnLoad(this.gameObject);

    }

    public static void CoinsGained()
    {
        float difference = GameManager.instance.coins - coinStart;
        if (difference > 0)
        {
            GameAnalytics.NewResourceEvent(GAResourceFlowType.Source, "Coins", difference, "Coins", "Coin");
        }
    }
}

