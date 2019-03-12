using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EndTweenController : MonoBehaviour {

    [SerializeField] float shakeDuration = 0.5f;
    [SerializeField] float shakeStrength = 0.005f;
    [SerializeField] int shakeVibrato = 5;
    [SerializeField] float shakeRandomness = 50f;

    private Vector3 starPos;
    private void Start()
    {
        starPos = this.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ShakeEnd());
    }

    IEnumerator ShakeEnd()
    {
        
        Tween myTween = this.transform.DOShakePosition(shakeDuration,new Vector3(1,0,1) * shakeStrength, shakeVibrato, shakeRandomness, false, true);
        yield return myTween.WaitForCompletion();
        this.transform.DOMove(starPos, 0.5f);
    }

    
}
