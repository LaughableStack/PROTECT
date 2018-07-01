using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour {
    public int toughness = 1;
    public float firespeed = 1;
    public int timer = 0;
    public int health = 1;
    public int direction = -1;
    public GameObject pointA;
    public GameObject pointB;
    public GameObject gun;
    public GameObject bullet;
	// Use this for initialization
	void Start () {
		foreach (GameObject point in GameObject.FindGameObjectsWithTag("Point"))
        {
            if (point.name == "PointA")
            {
                pointA = point;
            } else if (point.name == "PointB")
            {
                pointB = point;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
        timer++;
        if (timer%(100*firespeed)==0)
        {
            Instantiate(bullet, gun.transform.position, Quaternion.identity);
        }
        transform.Translate(transform.right * direction * Time.deltaTime);
        if (transform.position.x > pointB.transform.position.x || transform.position.x < pointA.transform.position.x)
        {
            transform.Translate(transform.up * 100 * Time.deltaTime);
            direction *= -1;
        }
        if (pointA.transform.position.y > transform.position.y)
        {
            Destroy(this.gameObject);
        }
	}
}
