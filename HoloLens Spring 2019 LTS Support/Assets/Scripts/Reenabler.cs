using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reenabler : MonoBehaviour
{
    public BaseTower instance;
    // Start is called before the first frame update
    void Start()
    {
        if(instance.enabled == false)
        {
            instance.enabled = true;
        }
    }

}
