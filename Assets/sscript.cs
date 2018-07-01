using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sscript : MonoBehaviour {
    public GameObject character;
    public GameObject overarch;
    public bool enemy;
	// Use this for initialization
	void Start () {
        this.GetComponent<SpriteRenderer>().enabled = false;
	}
    IEnumerator Example()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(overarch);
    }
    // Update is called once per frame
    void Update () {
        transform.position = character.transform.position;
        transform.rotation = character.transform.rotation;
	}
    public void die()
    {
        character.GetComponent<SpriteRenderer>().enabled = false;
        this.GetComponent<SpriteRenderer>().enabled = true;
        this.GetComponent<Animator>().Play("Death");
        StartCoroutine(Example());
    }
}
