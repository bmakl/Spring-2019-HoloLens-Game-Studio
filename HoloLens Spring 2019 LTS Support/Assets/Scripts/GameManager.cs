using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    [Header("Level Stats")]
    public float health = 100f;
    public GameObject endPoint;  //if enemy collides with this - 1 health
    public int waveCount = 1;   //counts the wave and is ther multi for num of enemies spawned

    [Header("Coins")]
    public int coins;

    [Header("Spawner")]
    public GameObject[] enemyPrefab;
    //public GameObject enemyFastPrefab;
    public Transform spawnPoint;

    public int enemyType = 0; // the enemy that si being spawned
    public float timeBetweenWaves = 5f; // time between waves, can be changed in inspactor 
    private float countdown = 2f;
    public float timeBetweenEnemies = 0.5f; //time between enemies can be changed in inspector
    public int waveSize = 10;

    private int waveIndex = 0;
    private int enemyCount = 0; // how many enemies have spawned in the wave, resets after each wave
    // public int enemyChange = 1; 
    private int enemyDif = 1; // the enemy type that is being spawned

    public Text crashCount;
    public Text coinCount;

    void Update()
    {
        Spawner(); // so it spawns without the start button DELETE IT ONCE ATTACKED TO BUTTON

        if (enemyCount == 0)
        {
            enemyType = 0;
        }
        else if (enemyCount % 10 == 0)
        {
            enemyType = 3;
        }
        else if (enemyCount % 5 == 0)
        {
            enemyType = 2;
        }
        else if (enemyCount % 3 == 0)
        {
            enemyType = 1;
        }
        else
        {
            enemyType = 0;
        }

        crashCount.text = "Spawned " + enemyCount.ToString();
        coinCount.text = "Coins: " + coins.ToString();
    }
    IEnumerator SpawnWave()
    {
        waveIndex = waveSize; // how many spawn per wave
        for (int i = 0; i < waveIndex; i++)
        {
            enemyCount++;
            SpawnEnemy();
            yield return new WaitForSeconds(timeBetweenEnemies);
        }
        enemyCount = 0; // each wave starts at zero
        waveCount++; // wave count
        waveSize = waveSize + 5; // how many spawn per wave, can be changed in inspector
    }
    void Spawner()
    {
        if (countdown <= 0f) // spawns waves 5sec apart
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    void SpawnEnemy()
    {
        int enemyIndex = enemyType;

        Instantiate(enemyPrefab[enemyIndex], spawnPoint.position, spawnPoint.rotation);
        //Instantiate(enemyFastPrefab, spawnPoint.position, spawnPoint.rotation);

    }
}
