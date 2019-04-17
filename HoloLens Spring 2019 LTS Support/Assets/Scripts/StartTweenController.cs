using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class StartTweenController : MonoBehaviour, IFocusable
{
    [SerializeField] float tweenAmmount;
    [SerializeField] float tweenDuration;

    private Vector3 originalScale;//Original scale of object before tween

    public void OnFocusEnter()
    {
        originalScale = this.transform.localScale;
        TweenManager.instance.TweenScale(this.transform, tweenAmmount, tweenDuration);
    }

    public void OnFocusExit()
    {
        TweenManager.instance.Descale(this.transform, originalScale, tweenDuration);
    }
}
