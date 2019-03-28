using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [Header("Bullet Stats")]
    public float bulletSpeed =5f;
    private Transform target;
    public float bulletDamage;
    Vector3 enemyCenter;
    private BaseEnemy enemy;
    private float timeAlive;

    public void Seek(Transform _target, float damage)//Grabs target from TowerTemplate
    {
        target = _target;
        bulletDamage = damage;
        if (_target.CompareTag("Bat"))
        {
            Debug.Log("Bat collider");
            enemyCenter = target.GetComponent<SphereCollider>().bounds.center;
        }
        else
        {
            enemyCenter = target.GetComponent<MeshCollider>().bounds.center;
        }
        enemy = target.GetComponent<BaseEnemy>();
    }


    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.deltaTime;
        if (timeAlive >= 0.05f)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        }
        if (target == null || !enemy.eligibleTarget)//Checks if there is a target, if not destorys bullet
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir;
        float distanceThisFrame;
        dir = enemyCenter - transform.position;
        distanceThisFrame = bulletSpeed * Time.deltaTime;
        transform.Translate(dir.normalized * distanceThisFrame, Space.World); //Moves Bullet
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pumpkin") ||other.CompareTag("Skeleton") || other.CompareTag("Bat") || other.CompareTag("Ghost"))
        {
            this.GetComponent<MeshRenderer>().enabled = false;
            Debug.Log("Bullet disable");
        }
    }

}
