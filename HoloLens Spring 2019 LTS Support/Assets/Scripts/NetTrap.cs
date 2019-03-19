using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetTrap : MonoBehaviour {

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Skeleton"))
        {
            Debug.Log("Net was hit by " + other.tag);
            other.GetComponent<BaseEnemy>().speed *= 0.5f;
        }
        if(other.CompareTag("Zombie"))
        {
            Destroy(this.gameObject);
        }
    }
}
