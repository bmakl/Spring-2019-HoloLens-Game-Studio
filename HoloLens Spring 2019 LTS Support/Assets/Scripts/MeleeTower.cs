using System.Collections;
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


    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pumpkin") || other.CompareTag("Skeleton") || other.CompareTag("Ghost")||other.CompareTag("Bat") || other.CompareTag("Boss"))
        {
            Debug.Log("Melee Tower Found Enemies");
            //found enemies   
            if (attackCountdown <= 0f) //checks if the attack is off cooldown 
            {
                Debug.Log("Attack Countdown is fine");
                other.gameObject.GetComponent<BaseEnemy>().health -= attackDamage;
                Debug.Log(other.gameObject.GetComponent<BaseEnemy>().health);
                //shooting

                attackCountdown = 1f * attackSpeed;
            }

        }
    }



}

