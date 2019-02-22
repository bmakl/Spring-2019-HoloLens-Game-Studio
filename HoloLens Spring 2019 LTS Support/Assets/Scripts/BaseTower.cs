using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class BaseTower : MonoBehaviour, IInputClickHandler
{


    [Header("Turret Base Stats")]
    public float radius = 5f;
    public float attackSpeed = 1f;
    [HideInInspector]
    public float fireRate = 0f;
    public float attackDamage = 10f;

    [Header("Turret Upgrade 1 Stats")]
    public float upgrade1Damage = 3f;
    public float upgrade1AttackSpeed = 3f;
    public float upgrade1Radius = 6f;

    [Header("Turret Upgrade 2 Stats")]
    public float upgrade2Damage = 5f;
    public float upgrade2AttackSpeed = 5f;
    public float upgrade2Range = 7f;


    [Header("Setup Stuff")]
    public GameObject bulletPrefab;
    public Transform firePoint;

    public Queue<GameObject> Pumpkin;
    public Queue<GameObject> Skeleton;
    public Queue<GameObject> Bat;
    public Queue<GameObject> Ghost;
    public Queue<GameObject> Boss;

    private GameObject tempTarget;
    private GameObject currentTarget;

    public int TargetingLevel;

    public float clicks = 0;

    private void Awake()
    {
        Pumpkin = new Queue<GameObject>();
        Skeleton = new Queue<GameObject>();
        Bat = new Queue<GameObject>();
        Ghost = new Queue<GameObject>();
        Boss = new Queue<GameObject>();
        TargetingLevel = 1;
    }

    private void Start()
    {
        currentTarget = null;
        tempTarget = null;
        clicks = 0;
    }

    private void Update()
    {

        UpdateTarget();

        //RotateTower();
        if(currentTarget == null)
        {
            return;
        }
        if (currentTarget.GetComponent<BaseEnemy>().health > 0 && fireRate <= 0f) //checks if the attack is off cooldown 
        {

            Shoot();

            fireRate = 1f / attackSpeed;
        }

        if(currentTarget.GetComponent<BaseEnemy>().health <= 0)
        {
            GameManager.instance.coins += currentTarget.GetComponent<BaseEnemy>().coinDrop;
        }

        fireRate -= Time.deltaTime;



    }


    public virtual void UpdateTarget() //Updates the target to the first target that enters the radius
    {
        BaseEnemy tempTargetScript;
        if(TargetingLevel == 1)
        {
            if (Skeleton.Count != 0)
            {
                if(Skeleton.Peek() == null)
                {
                    Skeleton.Dequeue();
                    return;
                }
                tempTarget = Skeleton.Dequeue();
                tempTargetScript = tempTarget.GetComponent<BaseEnemy>();
                if (tempTarget.GetComponent<BaseEnemy>() == null)
                {
                    Debug.LogError("Attach Base Enemy Script to Skeletons");
                }
                if (tempTargetScript.health > 0 && tempTargetScript.eligibleTarget)
                {
                    currentTarget = tempTarget;
                }
            }
            if(Bat.Count != 0 && Skeleton.Count == 0)
            {
                tempTarget = Bat.Dequeue();
                tempTargetScript = tempTarget.GetComponent<BaseEnemy>();
                if (tempTarget.GetComponent<BaseEnemy>() == null)
                {
                    Debug.LogError("Attach Base Enemy Script to Bat");
                }
                if (tempTargetScript.health > 0 && tempTargetScript.eligibleTarget)
                {
                    currentTarget = tempTarget;
                }
            }
            if (Pumpkin.Count != 0 && Bat.Count == 0 && Skeleton.Count == 0)
            {
                if (Pumpkin.Peek() == null)
                {
                    Pumpkin.Dequeue();
                    return;
                }
                tempTarget = Pumpkin.Dequeue();
                tempTargetScript = tempTarget.GetComponent<BaseEnemy>();
                if (tempTarget.GetComponent<BaseEnemy>() == null)
                {
                    Debug.LogError("Attach Base Enemy Script to Pumpkin");
                }
                if (tempTargetScript.health > 0 && tempTargetScript.eligibleTarget)
                {
                    currentTarget = tempTarget;
                }
            }
            if (Ghost.Count != 0 && Pumpkin.Count == 0 && Bat.Count == 0 && Skeleton.Count == 0)
            {
                tempTarget = Ghost.Dequeue();
                tempTargetScript = tempTarget.GetComponent<BaseEnemy>();
                if (tempTarget.GetComponent<BaseEnemy>() == null)
                {
                    Debug.LogError("Attach Base Enemy Script to Ghost");
                }
                if (tempTargetScript.health > 0 && tempTargetScript.eligibleTarget)
                {
                    currentTarget = tempTarget;
                }
            }
            if (Boss.Count != 0 && Ghost.Count == 0 && Pumpkin.Count == 0 && Bat.Count == 0 && Skeleton.Count == 0)
            {
                tempTarget = Boss.Dequeue();
                tempTargetScript = tempTarget.GetComponent<BaseEnemy>();
                if (tempTarget.GetComponent<BaseEnemy>() == null)
                {
                    Debug.LogError("Attach Base Enemy Script to Boss");
                }
                if (tempTargetScript.health > 0 && tempTargetScript.eligibleTarget)
                {
                    currentTarget = tempTarget;
                }
            }

        }



    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enemy Entered");
        if (other.CompareTag("Pumpkin"))
        {
            Pumpkin.Enqueue(other.gameObject);
            Debug.Log("Pumpkin detected");
        }
        else if (other.CompareTag("Skeleton"))
        {
            Skeleton.Enqueue(other.gameObject);
            Debug.Log("Skeleton detected");
        }
        else if (other.CompareTag("Ghost"))
        {
            Ghost.Enqueue(other.gameObject);
        }
        else if (other.CompareTag("Bat"))
        {
            Bat.Enqueue(other.gameObject);
        }
        else if (other.CompareTag("Boss"))
        {
            Boss.Enqueue(other.gameObject);
        }
        else if (other.CompareTag("Bullet"))
        {
            Debug.Log("Bullet Fired");
        }
        else
        {
            Debug.LogError("Nothing found. Check enemy tags");
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        Debug.Log("Enemy Entered");
        if (other.CompareTag("Pumpkin"))
        {
            if(Pumpkin.Count > 0)
            {
                Pumpkin.Dequeue();
                Debug.Log("Pumpkin detected");
            }
            
        }
        else if (other.CompareTag("Skeleton"))
        {
            if(Skeleton.Count > 0)
            {
                Skeleton.Dequeue();
                Debug.Log("Skeleton detected");
            }
           
        }
        else if (other.CompareTag("Ghost"))
        {
            Ghost.Dequeue();
        }
        else if (other.CompareTag("Bat"))
        {
            Bat.Dequeue();
        }
        else if (other.CompareTag("Boss"))
        {
            Boss.Dequeue();
        }
        else
        {
            Debug.LogWarning("Nothing found. Check enemy tags");
        }
    }



    public virtual void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); //creates the bullet and casts to Game Object
        Bullet bullet = bulletGO.GetComponent<Bullet>(); //

        if (bullet != null)
        {
            bullet.Seek(currentTarget.transform, attackDamage); //passes the target to bullet script
        }
        else if (bullet == null)
        {
            Debug.LogError("Bullet does not exist");
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (clicks == 0)
        {
            Upgrade1();
            clicks++;
        }

        else if (clicks == 1)
        {
            Upgrade2();
            clicks++;
        }
    }

    private void Upgrade1()
    {
        attackDamage = upgrade1Damage;
        radius = upgrade1Radius;
        attackSpeed = upgrade1AttackSpeed;

    }


    private void Upgrade2()
    {
        attackDamage = upgrade2Damage;
        radius = upgrade2Range;
        attackSpeed = upgrade2AttackSpeed;

    }
}

