using UnityEngine;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;
using GameAnalyticsSDK;

public class BaseEnemy : MonoBehaviour, IInputClickHandler
{

    [Header("Enemy Stats")]
    public float damageToPlayer;
    public float speed;
    public float health;
    public float coinDrop;
    public bool eligibleTarget;
    public bool SkeletonHit;
    public bool slowed;
    public float rotationStrength = 15f;
    public bool upGrade = false;
    [HideInInspector] public bool killed = false;

    private Transform target;
    private int WavePointIndex = 0;
    public int waypointPassed;

    public int playerDamage;
    public int SkeletonsKilled;

    public Text successfulHits;

    #region EnemySetup
    private void Awake()
    {
        if(this.gameObject.CompareTag("Pumpkin"))
        {
            speed = 0.3f;
            health = 20;
            coinDrop = 25;
            playerDamage = 1;
            slowed = false;
            
        }
        if(this.gameObject.CompareTag("Ghost"))
        {
            speed = 0.1f;
            health = 35;
            coinDrop = 100;
            playerDamage = 10;
            slowed = false;
        }
        if (this.gameObject.CompareTag("Bat"))
        {
            speed = 0.6f;
            health = 15;
            coinDrop = 50;
            playerDamage = 5;
            slowed = false;
        }
        if (this.gameObject.CompareTag("Skeleton"))
        {
            speed = 0.7f;
            health = 10;
            coinDrop = 75;
            playerDamage = 10;
            SkeletonHit = false;
            slowed = false;
        }
        if(this.gameObject.CompareTag("Zombie"))
        {
            speed = 0.1f;
            health = 60;
            coinDrop = 20;
            playerDamage = 1;
            slowed = false;
        }
        if (this.gameObject.CompareTag("Boss"))
        {
            speed = 0.06f;
            health = 500;
            coinDrop = 250;
            playerDamage = 1;
            slowed = false;
        }
    }
    #endregion

    void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
        float str = Mathf.Min(rotationStrength * Time.deltaTime, 1);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, str);
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        

        if (Vector3.Distance(transform.position, target.position) <= 0.01f)
        {
            GetNextWaypoint();
        }

        /*if(this.gameObject.GetComponent<BaseEnemy>().health <= 0 && !killed)
        {
            GameManager.instance.coins += coinDrop;
            Debug.Log(health);
            GameManager.instance.enemyCount--;
            Debug.Log("bye bye");
            killed = true;
            Destroy(transform.parent.gameObject);
        }*/

        if(GameManager.instance.waveCount %10 == 0)
        {
            upGrade = true;
        }

       
    }

    void GetNextWaypoint()
    {
        if (WavePointIndex >= Waypoints.points.Length - 1)
        {
            if(health <= 9)
            {
                damageToPlayer = 1;
            }
            else
            {
                damageToPlayer = health * 0.1f;
            }
            GameManager.instance.enemyCount--;
            Destroy(transform.parent.gameObject);
            GameManager.instance.health -= damageToPlayer;
            return;
        }
        WavePointIndex++;
        waypointPassed++;
        target = Waypoints.points[WavePointIndex];
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag + "Entered Radiuys");
        if(other.CompareTag("Basic Tower") || other.CompareTag("Melee Tower") || other.CompareTag("Debuff Tower") || other.CompareTag("Powerful Tower"))
        {
            eligibleTarget = true;
        }
        if (other.CompareTag("Bullet") && this.CompareTag("Ghost"))
        {
            var ghostScrirpt = GetComponent<GhostEnemy>();
            if (!ghostScrirpt.targetable)
            {
                Debug.Log("Ghost is invulnerable");
                Destroy(other.gameObject);
            }
            else
            {
                Debug.Log("Ghost is targeted");
                health -= other.GetComponent<Bullet>().bulletDamage;
                if (this.gameObject.GetComponent<BaseEnemy>().health <= 0 && !killed)
                {
                    Debug.Log("Ghost is taking damage");
                    GameManager.instance.coins += coinDrop;
                    GameManager.instance.enemyCount--;
                    killed = true;
                    Destroy(transform.parent.gameObject);
                }

                
            }
        }
        if(other.CompareTag("Bullet") && this.CompareTag("Skeleton"))
        {
            if(!SkeletonHit)
            {
                health -= other.GetComponent<Bullet>().bulletDamage;
                Destroy(other.gameObject);
                if (health <= 0)
                {
                    GameManager.instance.coins += coinDrop;
                    GameManager.instance.enemyCount--;
                    killed = true;
                    Destroy(transform.parent.gameObject);
                    GameAnalytics.NewDesignEvent("EnemyKilled:Skeleton");
                }
                SkeletonHit = true;
                if (SkeletonHit)
                {
                    this.gameObject.GetComponent<BaseEnemy>().speed *= 2;
                }
            }
            else
            {
                health -= other.GetComponent<Bullet>().bulletDamage;
                Destroy(other.gameObject);
                if (health <= 0 && !killed)
                {
                    GameManager.instance.coins += coinDrop;
                    GameManager.instance.enemyCount--;
                    killed = true;
                    Destroy(transform.parent.gameObject);
                    GameAnalytics.NewDesignEvent("EnemyKilled:Skeleton");
                }
            }
        }
        else if(other.CompareTag("Bullet") && this.CompareTag("Pumpkin"))
        {
            health -= other.GetComponent<Bullet>().bulletDamage;
            Debug.Log("Bullet hit");
            Destroy(other.gameObject);
            if (health <= 0 && !killed)
            {
                GameManager.instance.coins += coinDrop;
                ParticleManager.instance.DeathParticle(this.transform);
                GameManager.instance.enemyCount--;
                Destroy(transform.parent.gameObject);
                GameAnalytics.NewDesignEvent("EnemyKilled:Pumpkin");
            }
        }
        else if (other.CompareTag("Bullet") && this.CompareTag("Bat"))
        {
            health -= other.GetComponent<Bullet>().bulletDamage;
            Debug.Log("Bullet hit");
            Destroy(other.gameObject);
            if (health <= 0 && !killed)
            {
                GameManager.instance.coins += coinDrop;
                ParticleManager.instance.DeathParticle(this.transform);
                GameManager.instance.enemyCount--;
                Destroy(transform.parent.gameObject);
                GameAnalytics.NewDesignEvent("EnemyKilled:Bat");
            }
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Basic Tower") || other.CompareTag("Melee Tower") || other.CompareTag("Powerful Tower") || other.CompareTag("Debuff Tower"))
        {
            eligibleTarget = false;
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if(GazeManager.Instance.HitInfo.transform.CompareTag("Skeleton"))
        {
            Debug.Log("Player Hit A Skeleton");
            GazeManager.Instance.HitInfo.transform.gameObject.GetComponent<BaseEnemy>().health -= playerDamage;
            SkeletonsKilled++;
            successfulHits.text = "Successful Hits: " + SkeletonsKilled.ToString();
        }
    }

    public void upgradeEnemy()
    {
        if(upGrade== true)
        {
            health = health * 1.25f;
            coinDrop = coinDrop * 1.25f;
            upGrade = false;
        }

    }
}
