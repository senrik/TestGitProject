using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}

    void LoadScene()
    {
        if (SceneManager.GetActiveScene().name == "scene01")
        {
            SceneManager.LoadScene("scene02");
        }
        else
        {
            SceneManager.LoadScene("scene01");
        }
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadScene();
        }
	}
}
