using UnityEngine;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;

public class BaseEnemy : MonoBehaviour, IInputClickHandler
{

    [Header("Enemy Stats")]
    public float damageToPlayer;
    public float speed;
    public float health;
    public int coinDrop;
    public bool eligibleTarget;
    public bool SkeletonHit;
    public bool slowed;
    public float rotationStrength = 15f;

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
            coinDrop = 10;
            playerDamage = 1;
            slowed = false;
            
        }
        if(this.gameObject.CompareTag("Ghost"))
        {
            speed = 0.1f;
            health = 35;
            coinDrop = 20;
            playerDamage = 1;
            slowed = false;
        }
        if (this.gameObject.CompareTag("Bat"))
        {
            speed = 0.6f;
            health = 15;
            coinDrop = 15;
            playerDamage = 1;
            slowed = false;
        }
        if (this.gameObject.CompareTag("Skeleton"))
        {
            speed = 0.7f;
            health = 10;
            coinDrop = 5;
            playerDamage = 1;
            SkeletonHit = false;
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

        if(health <= 0)
        {
            GameManager.instance.coins += coinDrop;
            Destroy(this.gameObject);
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
            Destroy(gameObject);
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
                Destroy(other.gameObject);
            }
            else
            {
                GameManager.instance.coins += coinDrop;
                Destroy(this.gameObject);
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
                    Destroy(this.gameObject);
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
                if (health <= 0)
                {
                    GameManager.instance.coins += coinDrop;
                    Destroy(this.gameObject);
                }
            }
        }
        else if(other.CompareTag("Bullet") && !this.CompareTag("Skeleton") && !this.CompareTag("Ghost"))
        {
            health -= other.GetComponent<Bullet>().bulletDamage;
            Debug.Log("Bullet hit");
            Destroy(other.gameObject);
            if (health <= 0)
            {
                GameManager.instance.coins += coinDrop;
                Destroy(this.gameObject);
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
}
