using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lesson2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int a = 7;
        if (a < 5){
            Debug.Log("aは5よりちいさい");
        }
        else{
            Debug.Log("aは5より大きい");
        }
        Debug.Log("終了");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
