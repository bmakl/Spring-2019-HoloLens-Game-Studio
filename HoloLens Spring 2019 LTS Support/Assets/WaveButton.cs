using UnityEngine;
using HoloToolkit.Unity.InputModule;
using GameAnalyticsSDK;

public class WaveButton : MonoBehaviour  {


    private void Update()
    {
        if (!GameManager.instance.Spawn && GameManager.instance.enemyCount <= 0)
        {
            ButtonManager.instance.EnableButton();
            Debug.Log("In the if statement");

        }
        Debug.Log("Calling Spawner");
    }

    public void StartWave()
    {
        GameManager.instance.Spawn = true;
        GameManager.instance.waveCount++;
        //GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, GameManager.instance.waveCount.ToString());
        ButtonManager.instance.DisableButton();
    }
        

}
