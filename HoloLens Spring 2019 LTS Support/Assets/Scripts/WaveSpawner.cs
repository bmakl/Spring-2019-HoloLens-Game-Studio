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
        if (countdown <= 0 && !inWave && !GameManager.instance.EndlessModeEnabled)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWave;
            return;
        }
        else if(countdown <= 0 && !inWave && GameManager.instance.EndlessModeEnabled)
        {
            StartCoroutine(EndlessSpawnWave());
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
        if (GameManager.instance.waveCount % 5 == 0)
        {
            GameManager.instance.pumpkinHealth += 5;
            GameManager.instance.ghostHealth += 5;
            GameManager.instance.skeletonHealth += 5;
            GameManager.instance.batHealth += 5;
            GameManager.instance.zombieHealth += 5;
            GameManager.instance.bossHealth += 5;
        }
        foreach (GameObject e in wave.enemy)
        {
            SpawnEnemy(e);
            GameManager.instance.enemyCount++;
            yield return new WaitForSeconds(1f * wave.spawnRate);
        }
        inWave = false;
        AnalyticsManager.CoinsGained();
        GameManager.instance.Spawn = false;
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Wave " + GameManager.instance.waveCount.ToString());
        waveIndex++;
        UpgradeManager.sellTowerBool = true;
        GameManager.instance.sendCoinsData = true;

        if(waveIndex > 34)
        {
            GameManager.instance.EndlessModeEnabled = true;
            waveIndex = 10;
        }


    }
    IEnumerator EndlessSpawnWave()
    {
        UpgradeManager.sellTowerBool = false;
        Wave wave = waves[waveIndex];
        Debug.Log("Wave Spawning");
        inWave = true;
        if (GameManager.instance.waveCount % 5 == 0)
        {
            GameManager.instance.pumpkinHealth += 5;
            GameManager.instance.ghostHealth += 5;
            GameManager.instance.skeletonHealth += 5;
            GameManager.instance.batHealth += 5;
            GameManager.instance.zombieHealth += 5;
            GameManager.instance.bossHealth += 5;
        }
        foreach (GameObject e in wave.enemy)
        {
            SpawnEnemy(e);
            GameManager.instance.enemyCount++;
            yield return new WaitForSeconds(1f * wave.spawnRate);
        }
        inWave = false;
        AnalyticsManager.CoinsGained();
        GameManager.instance.Spawn = false;
        GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Wave " + GameManager.instance.waveCount.ToString());
        waveIndex++;
        UpgradeManager.sellTowerBool = true;
        GameManager.instance.sendCoinsData = true;

        if (waveIndex > 34)
        {
            waveIndex = 10;
        }


    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        enemiesAlive++;
    }

}
