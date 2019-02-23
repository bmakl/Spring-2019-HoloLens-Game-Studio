using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEnemy : MonoBehaviour
{
    public bool targetable = false;

    void Update()
    {
        StartCoroutine(GhostMode());
    }

    public IEnumerator GhostMode()
    {
        if (targetable == false)
        {
            targetable = false;
            yield return new WaitForSecondsRealtime(3f);
            targetable = true;
        }
        else if (targetable == true)
        {
            targetable = true;
            yield return new WaitForSecondsRealtime(5f);
            targetable = false;
        }



    }
}