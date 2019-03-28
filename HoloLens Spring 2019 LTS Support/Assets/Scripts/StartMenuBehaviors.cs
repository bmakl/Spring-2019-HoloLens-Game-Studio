using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuBehaviors : MonoBehaviour {

	public void StartButton()
    {
        Debug.Log("Loading PAX Scene");
        SceneManager.LoadScene(1);
    }

    public void Instructions()
    {
        Debug.Log("Loading Instructions");
        SceneManager.LoadScene(2);
    }

    public void Credits()
    {
        Debug.Log("Loading Credits");
        SceneManager.LoadScene(3);
    }

    public void Settings()
    {
        Debug.Log("Loading Settings");
    }
}
