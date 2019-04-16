using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSingleton : MonoBehaviour
{

    private static CameraSingleton instance;

    private void Awake()
    {
        if(instance != null)
        {
            instance = this;
        }
        else
        {
            Destroy(GameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
