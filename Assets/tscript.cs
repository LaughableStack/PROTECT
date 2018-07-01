using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tscript : MonoBehaviour {
    public GameObject death;
    public GameObject main;
    public void die()
    {
            main.GetComponent<escript>().dead = true;
            death.GetComponent<sscript>().die();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
