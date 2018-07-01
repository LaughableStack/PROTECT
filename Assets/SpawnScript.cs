using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {
    public int interval;
    public int timer;
    public GameObject pointB;
    public GameObject ship;
    float rand;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer++;
        rand = Random.Range(interval - (interval / 2), interval + (interval / 2));
        if (timer%rand == 0)
        {
            Instantiate(ship, pointB.transform.position, Quaternion.Euler(0,0,270));
        }
	}
}
