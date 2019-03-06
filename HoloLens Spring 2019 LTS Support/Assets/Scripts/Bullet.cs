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

    public void Seek(Transform _target, float damage)//Grabs target from TowerTemplate
    {
        target = _target;
        bulletDamage = damage;
        enemyCenter = target.GetComponent<MeshCollider>().bounds.center;
        enemy = target.GetComponent<BaseEnemy>();
    }


    // Update is called once per frame
    void Update()
    {
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

}
