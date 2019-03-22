using UnityEngine;
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

    bool waveStarted = false;

    private void Update()
    {
        if (!GameManager.instance.Spawn)
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
        UpgradeManager.sellTowerBool = false;
        Wave wave = waves[waveIndex];
        Debug.Log("Wave Spawning");
        GameManager.instance.Spawn = false;
        foreach (GameObject e in wave.enemy)
        {
            SpawnEnemy(e);
            GameManager.instance.enemyCount++;
            yield return new WaitForSeconds(1f * wave.spawnRate);
        }
        waveIndex++;
        UpgradeManager.sellTowerBool = true;
        GameManager.instance.waveCount++;
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
