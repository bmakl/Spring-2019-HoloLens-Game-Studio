using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class WaveButton : MonoBehaviour  {


    private void Update()
    {
        if (!GameManager.instance.Spawn && GameManager.instance.enemyCount <= 0)
        {
            ButtonManager.instance.EnableButton();

        }
        Debug.Log("Calling Spawner");
    }

    public void StartWave()
    {
        GameManager.instance.Spawn = true;
        ButtonManager.instance.DisableButton();
    }
        

}
