using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

[RequireComponent(typeof(BoxCollider))]
public class PathItems : MonoBehaviour, IInputClickHandler
{
    [SerializeField] GameObject itemToPlace;
    [SerializeField] float placeCoolDown;
    private bool canPlace = true;

    private void Update()
    {
        itemToPlace = GameManager.instance.trapToSpawn;
    }


    public void OnInputClicked(InputClickedEventData eventData)
    {

        if (itemToPlace == null)
        {
            return;
        }
        if (GazeManager.Instance.HitInfo.collider != null && canPlace)
        {
            Debug.Log(GazeManager.Instance.HitInfo.collider.name);
            if (GazeManager.Instance.HitInfo.collider.CompareTag("CornerPath"))//checks if raycast hit from gaze was the path tagged as path
            {
                if (GameManager.instance.coins >=GameManager.instance.trapCost ) 
                {
                    //(PlaceItem()); For testing cooldown if needed
                    GameManager.instance.coins -= (int)GameManager.instance.trapCost;
                    Instantiate(itemToPlace, GazeManager.Instance.HitInfo.collider.bounds.center, GazeManager.Instance.HitInfo.transform.rotation);
                    
                }
            }
            if (GazeManager.Instance.HitInfo.collider.CompareTag("Path"))//checks if raycast hit from gaze was the path tagged as path
            {
                if (GameManager.instance.coins >= GameManager.instance.trapCost)
                {
                    //(PlaceItem()); For testing cooldown if needed
                    GameManager.instance.coins -= (int)GameManager.instance.trapCost;
                    Instantiate(itemToPlace, GazeManager.Instance.HitInfo.point, GazeManager.Instance.HitInfo.transform.rotation);

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


