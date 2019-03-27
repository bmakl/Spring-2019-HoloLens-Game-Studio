using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;

public class AnalyticsManager : MonoBehaviour
{
    public void Awake()
    {
        GameAnalytics.Initialize();
    }

}
