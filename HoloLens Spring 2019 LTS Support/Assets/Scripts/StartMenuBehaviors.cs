using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuBehaviors : MonoBehaviour {

    public void MainMenu()
    {
        Debug.Log("Loading Main Menu");
        SceneManager.LoadScene(0);
    }

	public void StartButton(int sceneIndex)
    {
        Debug.Log("Loading PAX Scene");
        //SceneManager.LoadScene(1);
        StartCoroutine(LoadGamescene(sceneIndex)); //set sceneIndex in the inspector OnClick()
    }

    IEnumerator LoadGamescene(int sceneIndex)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneIndex);
        while (!op.isDone) { yield return null; } //loading scene, if u want to see the progress Debug.Log(op.progress);
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
    public void Standard()
    {
        Debug.Log("Loading Credits");
        SceneManager.LoadScene(4);
    }

    public void Settings()
    {
        Debug.Log("Loading Settings");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
