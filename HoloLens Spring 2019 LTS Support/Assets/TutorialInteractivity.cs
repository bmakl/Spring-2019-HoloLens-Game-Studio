using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInteractivity : MonoBehaviour
{

    public float TutorialTimer = 1.0f;
    public Material upHand;
    public Material downHand;
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
            Debug.Log("We are here at least");
            if(this.gameObject.GetComponent<Renderer>().material.shader == upHand.shader)
            {
                Debug.Log("Going to Downhand");
                this.gameObject.GetComponent<Renderer>().material.shader = downHand.shader;
            }
            else if(this.gameObject.GetComponent<Renderer>().material.shader== downHand.shader)
            {
                Debug.Log("Going to UpHand");
                this.gameObject.GetComponent<Renderer>().material.shader = upHand.shader;
            }
            TutorialTimer = 1.0f;
        }
    }
}
