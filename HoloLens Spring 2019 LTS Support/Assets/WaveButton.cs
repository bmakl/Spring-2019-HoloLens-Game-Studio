using UnityEngine;
using HoloToolkit.Unity.InputModule;
using GameAnalyticsSDK;

public class WaveButton : MonoBehaviour  {

    [SerializeField] AudioSource startSource; //Set this source from start button canvas if disconnected

    private void Update()
    {
        if (!GameManager.instance.Spawn && GameManager.instance.enemyCount <= 0)//Checks if the wave is finished spawning and if all enemies are dead
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Started Wave:" + GameManager.instance.waveCount.ToString());

            ButtonManager.instance.EnableButton(); //Enables button if passes the if check
        }
    }

    /// <summary>
    /// Function that is called on the start button to begin the wave
    /// </summary>
    public void StartWave()
    {
        startSource.Play();
        GameManager.instance.Spawn = true;
        GameManager.instance.waveCount++;
        //GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, GameManager.instance.waveCount.ToString());
        ButtonManager.instance.DisableButton();
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Started Wave:" + GameManager.instance.waveCount.ToString());
    }
        

}
