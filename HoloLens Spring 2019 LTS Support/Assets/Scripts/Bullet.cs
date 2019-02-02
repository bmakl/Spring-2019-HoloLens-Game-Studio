using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [Header("Bullet Stats")]
    public float bulletSpeed =5f;
    private Transform target;
    public float bulletDamage;

    public void Seek(Transform _target, float damage)//Grabs target from TowerTemplate

    {
        target = _target;
        bulletDamage = damage;
    }


    // Update is called once per frame
    void Update()
    {


        if (target == null)//Checks if there is a target, if not destorys bullet
        {
            Destroy(gameObject);
            return;

        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = bulletSpeed * Time.deltaTime;

        transform.Translate(dir.normalized * distanceThisFrame, Space.World); //Moves Bullet

    }

}
