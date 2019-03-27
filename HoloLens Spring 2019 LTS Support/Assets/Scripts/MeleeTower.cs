﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeTower : BaseTower
{


    [Header("Turret Stats")]
    public float attackCountdown = 0f;


    protected override void Awake()
    {
        base.Awake();
    }


    private void Update()
    {

        attackCountdown -= Time.deltaTime;

        if(attackCountdown <= 0)
        {
            StartCoroutine(meleeAttackCoolDown(null));
        }
    }

    IEnumerator meleeAttackCoolDown(Collider other)
    {
        attackCountdown = 0;
        yield return new WaitForSeconds(0.5f);
        if (other != null)
        {

            other.gameObject.GetComponent<BaseEnemy>().health -= attackDamage;
            if (other.gameObject.GetComponent<BaseEnemy>().health <= 0 && !other.gameObject.GetComponent<BaseEnemy>().killed)
            {
                GameManager.instance.enemyCount--;
                GameManager.instance.coins += other.gameObject.GetComponent<BaseEnemy>().coinDrop;
                ParticleManager.instance.DeathParticle(other.transform);
                other.gameObject.GetComponent<BaseEnemy>().killed = true;
                Destroy(other.gameObject);
            }

        }
        attackCountdown = 1f * fireRate;
    }


    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Pumpkin") || other.CompareTag("Skeleton") || other.CompareTag("Ghost")||other.CompareTag("Bat") || other.CompareTag("Boss"))
        {
            Debug.Log("Melee Tower Found Enemies");

            //found enemies   
            if (attackCountdown <= 0f) //checks if the attack is off cooldown 
            {
                StartCoroutine(meleeAttackCoolDown(other));
                Debug.Log("Attack Countdown is fine");

            //shooting

            }

        }
    }



}

