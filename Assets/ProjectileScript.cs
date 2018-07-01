using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {
    public int speed = -2;
    public bool enemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var targ = "";
        if (enemy)
        {
            targ = "Player";
        }
        else {
            targ = "Ship";
        }
        if (collision.CompareTag(targ))
        {
            Debug.Log("hit");
            if (enemy)
            {
                collision.GetComponent<mscript>().game_end();
            } else
            {
                collision.GetComponent<ShipScript>().health--;
            }
            Destroy(this.gameObject);
        } else if (collision.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.up * speed * Time.deltaTime);
        if (transform.position.y < -50)
        {
            Destroy(this.gameObject);
        }
	}
}
