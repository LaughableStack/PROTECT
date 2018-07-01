using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fscript : MonoBehaviour {
    public GameObject character;
    public bool cam;
	// Use this for initialization
	void Start () {
        if (cam)
        {
            transform.position = new Vector3(character.transform.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector2(character.transform.position.x, transform.position.y);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (character.transform.position.x > transform.position.x)
        {
            if (cam)
            {
                transform.position = new Vector3(character.transform.position.x, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector2(character.transform.position.x, transform.position.y);
            }
        }
	}
}
