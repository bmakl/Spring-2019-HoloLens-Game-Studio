using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;
using GameAnalyticsSDK;
public class BaseTower : MonoBehaviour//, IInputClickHandler
{


    [Header("Turret Base Stats")]
    public float radius = 5f;
    public int price = 100;
    public float fireRate = 1f;
    public float attackDamage = 10f;
    protected float currentFireRate = 0;
    bool canShoot = true;
    protected int lastUpgradeWave = 0;
    protected bool enableUpgrade = true;
    protected SphereCollider sphereCollider;

    public float upgradeCost = 100;
    public float slower = 0.5f;
    public GameObject node;


    [Header("Turret Upgrade 1 Stats")]
    public float upgrade1Damage = 3f;
    public float upgrade1fireRate = 3f;
    public float upgrade1Range = 6f;

    [Header("Turret Upgrade 2 Stats")]
    public float upgrade2Damage = 5f;
    public float upgrade2fireRate = 5f;
    public float upgrade2Range = 7f;


    [Header("Setup Stuff")]
    public GameObject bulletPrefab;
    public Transform firePoint;

    public Queue<GameObject> Pumpkin;
    public Queue<GameObject> Skeleton;
    public Queue<GameObject> Bat;
    public Queue<GameObject> Ghost;
    public Queue<GameObject> Boss;
    public Queue<GameObject> Zombie;

    [SerializeField] GameObject tempTarget;
    [SerializeField] GameObject currentTarget;

    public int TargetingLevel;

    public float clicks = 0;

    protected virtual void Awake()
    {
        Pumpkin = new Queue<GameObject>();
        Skeleton = new Queue<GameObject>();
        Bat = new Queue<GameObject>();
        Ghost = new Queue<GameObject>();
        Boss = new Queue<GameObject>();
        Zombie = new Queue<GameObject>();
        TargetingLevel = 1;

        sphereCollider = this.GetComponent<SphereCollider>();
        #region TowerAssign
        if(this.gameObject.CompareTag("Basic Tower"))
        {
            radius = 19.93f;
            attackDamage = 10f;
            fireRate = 0.75f;
            price = (int)GameManager.instance.baseCost;
            sphereCollider.radius = radius;
        }
        else if(this.gameObject.CompareTag("Melee Tower"))
        {
            radius = 17.03462f;
            attackDamage = 1f;
            fireRate = 0.75f;
            price = (int)GameManager.instance.meleeCost;
            sphereCollider.radius = radius;

        }
        else if(this.gameObject.CompareTag("Debuff Tower"))
        {
            radius = 17.03462f;
            attackDamage = 5f;
            fireRate = 1.5f;
            price = (int)GameManager.instance.debuffCost;
            sphereCollider.radius = radius;
        }
        else if(this.gameObject.CompareTag("Powerful Tower"))
        {
            radius = 15.46f;
            attackDamage = 15f;
            fireRate = 0.5f;
            fireRate = 0f;
            price = (int)GameManager.instance.powerfulCost;
            sphereCollider.radius = radius;
        }
        #endregion
    }

    private void Start()
    {
        currentTarget = null;
        tempTarget = null;
        clicks = 0;
    }

    private void Update()
    {
        Debug.Log(lastUpgradeWave);
        if (lastUpgradeWave < GameManager.instance.waveCount && enableUpgrade)
        {
            UpgradeManager.instance.EnableUpgradeButton();
            enableUpgrade = false;
        }
        UpdateTarget();
        //Debug.DrawLine(firePoint.transform.position, currentTarget.transform.position, Color.red, 0.1f);
        //RotateTower();
       

        if (currentTarget == null)
        {
            Debug.LogWarning("No Enemy");
            currentFireRate = 0;
            return;
        }
        //Debug.Log(currentTarget.GetComponent<BaseEnemy>().health + " " + fireRate);
        if (currentTarget.GetComponent<BaseEnemy>().health > 0 && canShoot && !this.gameObject.CompareTag("Debuff Tower")) //checks if the attack is off cooldown 
        {
            Debug.Log("shooting at" + currentTarget.tag);

            Shoot();
            StartCoroutine(ShootCoolDown());
        }

        if(currentTarget.GetComponent<BaseEnemy>().health <= 0)
        {
            GameManager.instance.coins += currentTarget.GetComponent<BaseEnemy>().coinDrop;//is this right?
        }

        if (currentFireRate <= 0)
        {
            currentFireRate = fireRate;
        }
        currentFireRate -= Time.deltaTime;

    }


    public virtual void UpdateTarget() //Updates the target to the first target that enters the radius
    {
        BaseEnemy tempTargetScript;
        #region TargetingLevels
        if(TargetingLevel == 1)
        {
            if(currentTarget == null && GameManager.instance.enemyCount > 0)
            {
                if (Skeleton.Count != 0)
                {
                    if (Skeleton.Peek() == null)
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
                if (Bat.Count != 0 && Skeleton.Count == 0)
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
                if(Zombie.Count != 0 && Ghost.Count == 0 && Pumpkin.Count == 0 && Bat.Count == 0 && Skeleton.Count == 0)
                {
                    tempTarget = Zombie.Dequeue();
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
        if(TargetingLevel == 2)
        {
            if(currentTarget == null)
            {
                if (Boss.Count != 0 )
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
                if(Zombie.Count != 0 && Boss.Count == 0)
                {
                    tempTarget = Zombie.Dequeue();
                    tempTargetScript = tempTarget.GetComponent<BaseEnemy>();
                    if (tempTarget.GetComponent<BaseEnemy>() == null)
                    {
                        Debug.LogError("Attach Base Enemy Script to Zombie");
                    }
                    if (tempTargetScript.health > 0 && tempTargetScript.eligibleTarget)
                    {
                        currentTarget = tempTarget;
                    }
                }
                if (Ghost.Count != 0 && Zombie.Count == 0 && Boss.Count == 0)
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
                if (Pumpkin.Count != 0 && Ghost.Count == 0 && Zombie.Count == 0 && Boss.Count == 0)
                {
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
                if (Bat.Count != 0 && Pumpkin.Count == 0 && Ghost.Count == 0 && Zombie.Count == 0 && Boss.Count == 0)
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
                if (Skeleton.Count != 0 && Bat.Count == 0 && Pumpkin.Count == 0 && Ghost.Count == 0 && Zombie.Count == 0 && Boss.Count == 0)
                {
                    tempTarget = Skeleton.Dequeue();
                    tempTargetScript = tempTarget.GetComponent<BaseEnemy>();
                    if (tempTarget.GetComponent<BaseEnemy>() == null)
                    {
                        Debug.LogError("Attach Base Enemy Script to Skeleton");
                    }
                    if (tempTargetScript.health > 0 && tempTargetScript.eligibleTarget)
                    {
                        currentTarget = tempTarget;
                    }
                }
            }
        }
        #endregion
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
        else if (other.CompareTag("Zombie"))
        {
            Zombie.Enqueue(other.gameObject);
        }
        else if (other.CompareTag("Bat"))
        {
            Bat.Enqueue(other.gameObject);
            Debug.Log("Bat in queue");
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

        if(this.gameObject.CompareTag("Debuff Tower") && !this.gameObject.CompareTag("Basic Tower") && !other.gameObject.CompareTag("Bullet") )
        {
            Debug.Log(other.gameObject);
            if(!other.gameObject.GetComponent<BaseEnemy>().slowed)
            {

                other.gameObject.GetComponent<BaseEnemy>().speed = other.gameObject.GetComponent<BaseEnemy>().speed * slower;
                other.gameObject.GetComponent<BaseEnemy>().slowed = true;
            }
            
        }

    }

    void OnTriggerExit(Collider other)
    {

        if (currentTarget == other.gameObject)
        {
            currentTarget = null;
        }
        Debug.Log("Enemy Entered");
        if (other.CompareTag("Pumpkin"))
        {
            if (Pumpkin.Count > 0)
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
            if (Ghost.Count > 0)
            {
                Ghost.Dequeue();
            }
        }
        else if (other.CompareTag("Zombie"))
        {
            if(Zombie.Count > 0)
            {
                Zombie.Dequeue();
            }
        }
        else if (other.CompareTag("Bat"))
        {
            if (Bat.Count > 0)
            {
                Bat.Dequeue();
            }
        }
        else if (other.CompareTag("Boss"))
        {
            Boss.Dequeue();
        }
        else
        {
            Debug.LogWarning("Nothing found. Check enemy tags");
        }

        if(this.gameObject.CompareTag("Debuff Tower"))
        {
            if (other.GetComponent<BaseEnemy>())
            {
                other.gameObject.GetComponent<BaseEnemy>().speed = other.gameObject.GetComponent<BaseEnemy>().speed * 2f;
                other.gameObject.GetComponent<BaseEnemy>().slowed = false;
            }
        }
    }



    public virtual void Shoot()
    {
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); //creates the bullet and casts to Game Object
        Bullet bullet = bulletGO.GetComponent<Bullet>(); //

        if (bullet != null && currentTarget.GetComponentInChildren<BaseEnemy>().eligibleTarget)
        {
            Debug.Log("Shoot");
            if (currentTarget.CompareTag("Bat"))
            { 
                bullet.Seek(currentTarget.GetComponent<SphereCollider>().transform, attackDamage); //passes the target to bullet script
            }
            else
            {
                bullet.Seek(currentTarget.GetComponentInChildren<MeshCollider>().transform, attackDamage); //passes the target to bullet script
            }
        }
        else if (bullet == null)
        {
            Debug.LogError("Bullet does not exist");
        }
    }

    IEnumerator ShootCoolDown()
    {
        canShoot = false;
        yield return new WaitForSecondsRealtime(fireRate);
        canShoot = true;
    }
    /*
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
    */


    
    public virtual void Upgrade()
    {
        lastUpgradeWave = GameManager.instance.waveCount;
        Debug.Log(lastUpgradeWave);

        Debug.Log("Upgraded Tower");

        if (this.CompareTag("Basic Tower"))
        {
            attackDamage = attackDamage * 1.25f;
            radius = radius * 1.25f;
            sphereCollider.radius = radius; //Sets radius of actual collider
            fireRate = fireRate / 1.1f;
            upgradeCost = upgradeCost * 2;
            enableUpgrade = true;
            UpgradeManager.instance.DisableUpgradeButton();
            GameAnalytics.NewDesignEvent("UpgradeTower:Tombstone");
        }
        if(this.CompareTag("Powerful Tower"))
        {
            attackDamage = attackDamage * 1.25f;
            radius = radius * 1.25f;
            sphereCollider.radius = radius; //Sets radius of actual collider
            fireRate = fireRate / 1.1f;
            upgradeCost = upgradeCost * 2;
            enableUpgrade = true;
            UpgradeManager.instance.DisableUpgradeButton();
            GameAnalytics.NewDesignEvent("UpgradeTower:TheHolyWrath");
        }
        if (this.CompareTag("Debuff Tower"))
        {
            radius = radius * 1.25f;
            upgradeCost = upgradeCost * 2;
            slower = slower * 0.9f;
            enableUpgrade = true;
            UpgradeManager.instance.DisableUpgradeButton();
            GameAnalytics.NewDesignEvent("UpgradeTower:CursedTower");
        }

    }
    
}

