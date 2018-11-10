using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Person p = new Person();
        p.firstname = "太郎";
        p.lastname = "山田";
        Debug.Log(p.GetFullName("★"));

	}
	
    class Person{
        public string firstname;
        public string lastname;

        public string GetFullName(string separator){
            return this.lastname + separator + this.firstname;
        }
        }
    


	// Update is called once per frame
	void Update () {
		
	}
}
