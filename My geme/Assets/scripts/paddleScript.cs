using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("test");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log(transform.position.x);
        
	}
}
