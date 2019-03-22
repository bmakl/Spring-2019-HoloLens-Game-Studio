using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class WaveButton : MonoBehaviour, IInputClickHandler  {

    public WaveSpawner waveSpawner;
    public void OnInputClicked(InputClickedEventData eventData)
    {
        waveSpawner.SetQueue();
        //waveSpawner.SpawnEnemy();
    }

}
