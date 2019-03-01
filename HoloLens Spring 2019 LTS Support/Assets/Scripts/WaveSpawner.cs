using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public static int enemiesAlive;
    public static bool waveStart = false;
    [SerializeField] Wave[] waves;

    [SerializeField] Transform spawnPoint;

    [SerializeField] float timeBetweenWave = 5f;
    private float countdown = 2f;

    private int waveIndex = 0;

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
        Debug.Log("Wave Spawning");
        for (int i = 0; i < wave.count; i++)
        {
            foreach (var e in wave.enemy)
            {
                SpawnEnemy(e);
            }
            yield return new WaitForSeconds(1f / wave.spawnRate);
        }
        GameManager.instance.Spawn = false;
        waveIndex++;
    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        enemiesAlive++;
    }

}
