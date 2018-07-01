using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winscript : MonoBehaviour {
    public GameObject player;
    public string level;
    public bool won = false;
    public GameObject canv;
	// Use this for initialization
	void Start () {
        canv.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update () {
		if (player.transform.position.x > transform.position.x)
        {
            won = true;
            player.GetComponent<mscript>().victory = true;
            if (!GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains(level))
            {
                GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Add(level);
            }
            canv.GetComponent<Canvas>().enabled = true;
        }
	}
}
