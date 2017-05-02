using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitMainCamera : MonoBehaviour {

    public GameObject mainCamera;

	// Use this for initialization
	void Start () {
        if (!GameObject.FindGameObjectWithTag("MainCamera"))
        {
            Instantiate(mainCamera);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
