using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInteractivity : MonoBehaviour
{

    public float TutorialTimer = 1.0f;
    public GameObject upHand;
    public GameObject downHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TutorialTimer -= Time.deltaTime;

        if(TutorialTimer <= 0)
        {
            Debug.Log("Timer is 0");
            if(upHand.activeSelf)
            {
                Debug.Log("Downhand On");
                upHand.SetActive(false);
                downHand.SetActive(true);
            }
            else if (downHand.activeSelf)
            {
                Debug.Log("Uphand on");
                downHand.SetActive(false);
                upHand.SetActive(true);
            }
            TutorialTimer = 1.0f;
        }
    }
}
