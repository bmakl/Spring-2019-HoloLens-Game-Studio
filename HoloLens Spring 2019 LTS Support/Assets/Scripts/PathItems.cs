using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class PathItems : MonoBehaviour, IInputClickHandler
{
    [SerializeField] GameObject barrier;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (GazeManager.Instance.HitInfo.collider != null)
        {
            Debug.Log(GazeManager.Instance.HitInfo.collider.name);
            if (GazeManager.Instance.HitInfo.collider.CompareTag("Path"))
            {
                Instantiate(barrier, GazeManager.Instance.HitInfo.point, GazeManager.Instance.HitInfo.transform.rotation);

            }
        }
    }
}
