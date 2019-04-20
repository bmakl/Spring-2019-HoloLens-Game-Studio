using UnityEngine;
using System.Collections;
using GameAnalyticsSDK;

public class WaveSpawner : MonoBehaviour
{
    public int enemiesAlive;
    public static bool waveStart = false;
    [SerializeField] Wave[] waves;
   

    [SerializeField] Transform spawnPoint;

    [SerializeField] float timeBetweenWave = 5f;
    private float countdown = 2f;

    [SerializeField] int waveIndex = 0;

    bool waveStarted = false;
    bool inWave = false;

    private void Update()
    {
        if (!GameManager.instance.Spawn )
        {
            //Debug.Log("Wave status is " + waveStart);
            countdown = 0;
            return;
        }
        if (countdown <= 0 && !inWave)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWave;
            return;
        }

        countdown -= Time.deltaTime;
    }
    IEnumerator SpawnWave()
    {
        UpgradeManager.sellTowerBool = false;
        Wave wave = waves[waveIndex];
        Debug.Log("Wave Spawning");
        inWave = true;
        
        foreach (GameObject e in wave.enemy)
        {
            SpawnEnemy(e);
            GameManager.instance.enemyCount++;
            yield return new WaitForSeconds(1f * wave.spawnRate);
        }
        GameManager.instance.EndlessWaveCheck = false;
        inWave = false;
        AnalyticsManager.CoinsGained();
        GameManager.instance.Spawn = false;
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Wave " + GameManager.instance.waveCount.ToString());
        waveIndex++;
        UpgradeManager.sellTowerBool = true;
        GameManager.instance.sendCoinsData = true;


    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        enemiesAlive++;
    }
}
