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

        if(attackCountdown <=0f)
        {
            attackCountdown = 1f * attackSpeed;
        }

    }


    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Pumpkin") || other.CompareTag("Skeleton") || other.CompareTag("Ghost")||other.CompareTag("Bat") || other.CompareTag("Boss"))
        {
            //found enemies   
            if (attackCountdown <= 0f) //checks if the attack is off cooldown 
            {
                other.gameObject.GetComponent<BaseEnemy>().health -= attackDamage;
                //shooting

                attackCountdown = 1f * attackSpeed;
            }

        }
    }



}

