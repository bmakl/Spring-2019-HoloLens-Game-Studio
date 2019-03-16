using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class UITrap : MonoBehaviour, IInputClickHandler
{
    [SerializeField] GameObject fenceTrap;
    [SerializeField] GameObject netTrap;
    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (this.CompareTag("FenceTrapUI"))//Checks if currently tagged object is this
        {
            GameManager.instance.trapCost = 100f;//sets cost in Game Manager of trap
            GameManager.instance.trapToSpawn = fenceTrap;
        }
        else if (this.CompareTag("NetTrapUI"))//Checks if currently tagged object is this
        {
            GameManager.instance.trapCost = 50f;//sets cost in Game Manager of trap
            GameManager.instance.trapToSpawn = netTrap;
        }
    }
}
