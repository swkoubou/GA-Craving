﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    


	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (SlotDesign.money < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
