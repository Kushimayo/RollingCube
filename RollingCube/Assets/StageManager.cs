using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour {
    public GameObject[] arrayObjects;
    public int arraySize;

    // Use this for initialization
    void Start () {
        arraySize = 3;
        arrayObjects[0] = GameObject.Find("StageShap1");
        arrayObjects[1] = GameObject.Find("StageShap2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
