using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class StartWave : MonoBehaviour, IInputClickHandler{

    WaveSpawner waveSpawner;


    public void OnInputClicked(InputClickedEventData eventData)
    {
        //if(waveSpawner.canStart) //if the wave can start, set canStart to false and begin SpawnWave couroutine
            //StartCoroutine(waveSpawner.SpawnWave()); idk what happened with wave spawner but theres missing things
    }
}
