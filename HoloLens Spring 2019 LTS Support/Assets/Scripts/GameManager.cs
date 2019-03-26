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
    public bool Spawn;

    [Header("Coins")]
    public float coins;

    [Header("Spawner")]
    public GameObject[] enemyPrefab;
    //public GameObject enemyFastPrefab;
    public Transform spawnPoint;

    public int enemyType = 0;
    public float timeBetweenWaves = 5f;
    private float countdown = 2f;
    public float timeBetweenEnemies = 0.5f;
    public int waveSize = 10;

    private int waveIndex = 0;
    public int enemyCount = 0; // how many enemies have spawned in the wave
    public int enemyChange = 1; // change to the type of enemy at this number of enemies spawned
    private int enemyDif = 1; // the enemy type that is being spawned

    public Text crashCount;
    public Text coinCount;
    [SerializeField] Text waveText;

    public float trapCost;
    public GameObject trapToSpawn;

    private void Start()
    {
        Spawn = false;
    }

    void Update()
    {
        
        if (enemyCount < 0)
        {
            enemyCount = 0;
        }

        /*countdown -= Time.deltaTime;
        Spawner();
        if(countdown <= 0)
        {
            countdown = 2f;
        }
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
        */
        crashCount.text = "Spawned " + enemyCount.ToString();
        coinCount.text = "Coins: " + coins.ToString();
        waveText.text = "Waves completed:  " + waveCount;



    }
    /*
    public IEnumerator SpawnWave()
    {
        waveIndex = waveSize; // how many spawn per wave
        for (int i = 0; i < waveIndex; i++)
        {
            enemyCount++;
            SpawnEnemy();
            yield return new WaitForSeconds(timeBetweenEnemies);
        }
        waveCount++;
        enemyCount = 0;
        waveSize = waveSize + 5;
        Spawn = false;
        Debug.Log("Youve reached the end of SpawnWave");
    }
    public void Spawner()
    {
        if(Spawn)
        {
            if (countdown <= 0f) // spawns waves 5sec apart
            {
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;
            }
        }
        else
        {
            Spawn = false;
        }
      

    }

    void SpawnEnemy()
    {
        int enemyIndex = enemyType;

        Instantiate(enemyPrefab[enemyIndex], spawnPoint.position, spawnPoint.rotation);
        //Instantiate(enemyFastPrefab, spawnPoint.position, spawnPoint.rotation);

    }
    */
}
