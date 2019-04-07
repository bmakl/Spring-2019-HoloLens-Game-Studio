using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class RadiusUI : MonoBehaviour,IFocusable
{

    [SerializeField] private GameObject radiusUI;

    public void OnFocusEnter()
    {
        Debug.Log("Stop looking at me");
        radiusUI.SetActive(true);
    }

    public void OnFocusExit()
    {
        Debug.Log("Come back");
        radiusUI.SetActive(false);
    }

}
