﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            GameObject.Find("StageManager").SendMessage("RestartGame");
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
