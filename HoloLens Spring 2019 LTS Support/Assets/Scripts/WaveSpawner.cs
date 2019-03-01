﻿using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public int enemiesAlive;
    public static bool waveStart = false;
    [SerializeField] Wave[] waves;

    [SerializeField] Transform spawnPoint;

    [SerializeField] float timeBetweenWave = 5f;
    private float countdown = 2f;

    [SerializeField] int waveIndex = 0;

    private void Update()
    {
        if (!   GameManager.instance.Spawn)
        {
            Debug.Log("Wave status is " + waveStart);
            countdown = 0;
            return;
        }
        if (countdown <= 0)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWave;
            return;
        }

        countdown -= Time.deltaTime;
    }

    IEnumerator SpawnWave()
    {
        Wave wave = waves[waveIndex];
       // for(int i = 0; i< waves.Length ; i++)
        //{
            Debug.Log("Wave Spawning");
            GameManager.instance.Spawn = false;
            foreach (GameObject e in wave.enemy)
            {
                SpawnEnemy(e);
                yield return new WaitForSeconds(1f * wave.spawnRate);
            }



            waveIndex++;
       // }

        /*if(waveIndex >= waves.Length+1)
        {
            yield return new WaitForSeconds(5f);
            SceneController.instance.LoadMenu();
        }*/
        
    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        enemiesAlive++;
    }

}
