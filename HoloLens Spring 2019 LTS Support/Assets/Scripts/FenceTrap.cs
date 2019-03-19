using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceTrap : MonoBehaviour {

    [SerializeField] int damageToEnemy = 30;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ghost") || other.CompareTag("Pumpkin") || other.CompareTag("Skeleton") || other.CompareTag("Boss")
            || other.CompareTag("Bat"))
        {
            other.GetComponent<BaseEnemy>().health -= damageToEnemy;
            Destroy(this.gameObject);
        }

        if(other.CompareTag("Zombie"))
        {
            Destroy(this.gameObject);
        }
    }
}
