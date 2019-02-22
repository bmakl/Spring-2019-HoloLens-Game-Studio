using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

[RequireComponent(typeof(BoxCollider))]
public class PathItems : MonoBehaviour, IInputClickHandler
{
    [SerializeField] GameObject fence;
    [SerializeField] float placeCoolDown;
    private bool canPlace = true;


    public void OnInputClicked(InputClickedEventData eventData)
    {

        if (fence == null)
        {
            Debug.LogError("Barrier is not assigned");
            return;
        }
        if (GazeManager.Instance.HitInfo.collider != null && canPlace)
        {
            Debug.Log(GazeManager.Instance.HitInfo.collider.name);
            if (GazeManager.Instance.HitInfo.collider.CompareTag("Path"))
            {
                if (GameManager.instance.coins >=100 ) 
                {
                    //(PlaceItem()); For testing cooldown if needed
                    GameManager.instance.coins -= 100;
                    Instantiate(fence, GazeManager.Instance.HitInfo.point, GazeManager.Instance.HitInfo.transform.rotation);
                }
            }
        }
    }

    IEnumerator PlaceItem()
    {
        canPlace = false;
        Debug.Log(canPlace);
        yield return new WaitForSecondsRealtime(placeCoolDown);
        canPlace = true;
        Debug.Log(canPlace);
    }
}


