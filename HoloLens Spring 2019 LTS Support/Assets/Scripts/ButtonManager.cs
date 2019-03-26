using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour {

    // Update is called once per frame


    public static ButtonManager instance;
    [SerializeField] Camera cam;
    private Button startButton;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        startButton = GetComponentInChildren<Button>();
    }

    public void EnableButton()
    {
        startButton.interactable = true;
    }

    public void DisableButton()
    {
        startButton.interactable = false;
    }

}
