using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaveSpawner : MonoBehaviour
{
    public int enemiesAlive;
    public bool waveStart = false;
    [SerializeField] Wave[] waves;

    [SerializeField] Level[] levels;
    private Queue<GameObject> spawner;
    public GameObject[] enemyTypes;
    /* 0 is Pumpkin
     * 1 is Bat
     * 2 is Skeleton
     * 3 is Ghost
     * */

    [SerializeField] Transform spawnPoint;

    [SerializeField] float timeBetweenWave = 5f;
    private float countdown = 2f;

    [SerializeField] int waveIndex = 0;

    bool waveStarted = false;

    private void Start()
    {
        spawner = new Queue<GameObject>();
        
    }

    private void Update()
    {
        /*if (!GameManager.instance.Spawn)
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
        GameManager.instance.Spawn = false;
        foreach (GameObject e in wave.enemy)
        {
            SpawnEnemy(e);
            GameManager.instance.enemyCount++;
            yield return new WaitForSeconds(1f * wave.spawnRate);
        }
        waveIndex++;
       // }

        if(waveIndex >= waves.Length+1)
        {
            yield return new WaitForSeconds(5f);
            SceneController.instance.LoadMenu();
        }*/
        
    }

   /* public void SpawnEnemy()
    {
        for(int i = 0; i <= spawner.Count; i++)
        {
            Debug.Log(spawner.Count);
            WaitToSpawn();
            GameObject objectToSpawn = spawner.Dequeue();
            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
            Debug.Log("Spawned enemy");
            enemiesAlive++;
        }   
        spawner.Clear();
        waveStart = false;
        
    }*/

    IEnumerator WaitToSpawn()
    {
        int secondsToWait = Random.Range(1,3);
        yield return new WaitForSeconds(secondsToWait);
    }


    public void SetQueue()
    {
        if(waveStart == false && spawner.Count == 0)
        {
            Debug.Log("entered QQQQ!!!!");
            for (int i = 0; i <= GameManager.instance.waveCount; i++)
            {
                Debug.Log(i);
                Debug.Log("entered first FOR");
                int pumpkins = levels[i].numPumpkins;
                int bats = levels[i].numBats;
                int skeletons = levels[i].numSkelly;
                int ghosts = levels[i].numGhosts;
                int j, k, l, m;
                if(pumpkins != 0 || bats != 0 || skeletons != 0 || ghosts != 0)
                {
                    Debug.Log("entered the WHILE!!");
                    if ( pumpkins > 0)
                    {
                        Debug.Log("Pumpkin For");
                        for (j = 0; (j <= 5) || (j<= pumpkins); j++)
                        {

                            //spawner.Enqueue(enemyTypes[0]);
                            Instantiate(enemyTypes[0]);
                            Debug.Log("Pumpkin added to Queue");
                            pumpkins--;
                        }

                    }
                    else if (skeletons != 0)
                    {
                        Debug.Log("Skeleton For");
                        for (k = 0; (k <= 2) || (k <= skeletons); k++)
                        {
                         
                            spawner.Enqueue(enemyTypes[2]);
                            skeletons--;
                        }
                    }
                    else if (bats != 0)
                    {
                        Debug.Log("Bat For");
                        for (l = 0; (l <= 3) || (l <= bats); l++)
                        {
                            
                            spawner.Enqueue(enemyTypes[1]);
                            bats--;
                        }
                    }
                    else if (ghosts != 0)
                    {
                        Debug.Log("Ghost For");
                        for (m = 0; (m <= 1) || (m <= ghosts); m++)
                        {
                            
                            spawner.Enqueue(enemyTypes[3]);
                            ghosts--;
                        }
                    }
                }
            }
            waveStart = true;
        }
        
    }

}
