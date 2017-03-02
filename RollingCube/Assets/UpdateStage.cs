using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateStage : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            Debug.Log("Do Update Stage");
            GameObject.Find("StageManager").SendMessage("UpdateStage");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
