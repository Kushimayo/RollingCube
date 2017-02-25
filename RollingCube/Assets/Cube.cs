using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    float KeyPressMoveVector = 0.1f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.right * 100 * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Vector3 moveLeft = new Vector3(0, 0, -KeyPressMoveVector);
            //moveLeft = moveLeft.normalized;
            //GetComponent<Rigidbody>().AddForce(moveLeft);
            GetComponent<Rigidbody>().AddForce(Vector3.left);
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right);
        } else if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }
    }
}
