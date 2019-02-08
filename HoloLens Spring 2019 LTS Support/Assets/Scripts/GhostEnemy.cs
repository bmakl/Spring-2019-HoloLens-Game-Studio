using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEnemy : MonoBehaviour
{

    public float tempHealth = 100000f;
    public float trueHealth = 0f;
    public bool abilityAvalible = true;

    public BaseEnemy enemyScript;

    void Start()
    {
        trueHealth = enemyScript.health; //set true hp to what the ghost has as hp
        enemyScript.health = tempHealth; //set temp value of (big number) so ghost cant die (invincible)
        enemyScript.health = trueHealth; //put ghost hp back to original number (invincible is over)

    }

    void Update()
    {
        StartCoroutine(GhostMode());
    }

    public IEnumerator GhostMode()
    {
        if (abilityAvalible == true)
        {
            enemyScript.health = tempHealth; //set temp value of (big number) so ghost cant die (invincible)
            yield return new WaitForSeconds(1f); // waits 2 seconds
            enemyScript.health = trueHealth; //put ghost hp back to original number (invincible is over)
            abilityAvalible = false;
        }
        else
        {
            yield return new WaitForSeconds(3f); //waits 5 seconds
            abilityAvalible = true;
        }

    }
}