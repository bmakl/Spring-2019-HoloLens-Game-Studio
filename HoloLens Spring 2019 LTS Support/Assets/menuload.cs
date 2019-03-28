using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuload : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(loadmenu());
	}
	
	IEnumerator loadmenu()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(0);

    }
}
