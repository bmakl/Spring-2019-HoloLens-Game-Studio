using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
    public static SceneController instance;

	// Use this for initialization
	void Start () {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void LoadMenu()
    {
        SceneManager.LoadScene("FakeMenu");
    }


    public void LoadPaxScene()
    {
        SceneManager.LoadScene("PAXScene");
    }
}
