 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void OnInputClicked(InputClickedEventData eventData)
    {
        SceneManager.LoadScene(1); //make sure the main game is 1 in build settings
    }
}
