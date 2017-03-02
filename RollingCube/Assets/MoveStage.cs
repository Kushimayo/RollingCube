using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStage : MonoBehaviour {
    float Speed = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    void MoveStageNomal()
    {
        float new_Z_position = transform.position.z - Speed;
        transform.position = new Vector3(transform.position.x, transform.position.y, new_Z_position);
    }
}
