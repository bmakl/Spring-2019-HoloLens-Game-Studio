using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenManager : MonoBehaviour {
    public static TweenManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// Scales the tween of the object called on
    /// </summary>
    /// <param name="tweenObject">Object to tween</param>
    /// <param name="scaleAmmount">Scale Value</param>
    /// <param name="tweenDuration">Duration of tween</param>
    public void TweenScale(Transform tweenObject, float scaleAmmount, float tweenDuration)
    {
        tweenObject.DOScale(tweenObject.localScale * scaleAmmount, tweenDuration);
    }

    /// <summary>
    /// Tweens back to original scale(needs referance to original scale)
    /// </summary>
    /// <param name="tweenObject">Object to tween</param>
    /// <param name="originalScale">Original scale of object before original tween</param>
    /// <param name="tweenDuration">Duration of tween</param>
    public void Descale(Transform tweenObject, Vector3 originalScale, float tweenDuration)
    {
        tweenObject.DOScale(originalScale, tweenDuration);
    }
}
