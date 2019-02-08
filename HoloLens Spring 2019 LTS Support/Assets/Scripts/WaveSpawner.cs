using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject enemyFastPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 9f;
    private float countdown = 2f;
    public float timeBetweenEnemies = 1f;

    private int waveIndex = 0;

    public IEnumerator SpawnWave()
    {
        if (waveIndex <= 9)
        {
            waveIndex++;
            for (int i = 0; i < waveIndex; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(timeBetweenEnemies);
            }
        }
        if(waveIndex >= 10)
        {
            for(int i = 0; i >= 1; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(timeBetweenEnemies);
            }
        }
        canStart = true;

    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        Instantiate(enemyFastPrefab, spawnPoint.position, spawnPoint.rotation);

    }
}
