using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class WaveButton : MonoBehaviour, IInputClickHandler  {

    
    public void OnInputClicked(InputClickedEventData eventData)
    {
        
        if(!GameManager.instance.Spawn && GameManager.instance.enemyCount <= 0)
        {
            GameManager.instance.Spawn = true;
        }
        Debug.Log("Calling Spawner");
    }

}
