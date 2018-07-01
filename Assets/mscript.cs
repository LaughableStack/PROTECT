using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mscript : MonoBehaviour {
    public GameObject shadow;
    public int interval = 35;
    public int intervalc = 0;
    public GameObject overarch;
    public SpriteRenderer mine;
    public SpriteRenderer shadows;
    public bool grounded;
    public GameObject deathcanva;
    public bool victory = false;
    public GameObject bullet;
    public List<GameObject> grounders = new List<GameObject>();
    // Use this for initializationa
    public void game_end()
    {
        if (!victory)
        {
            Debug.Log("dead");
            deathcanva.GetComponent<Canvas>().enabled = true;
            Destroy(overarch);
        }
    } 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            grounders.Add(other.gameObject);
        } else if (other.CompareTag("Enemy"))
        {
            other.GetComponent<tscript>().die();
            this.GetComponent<Rigidbody2D>().AddForce(transform.up * 500);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            grounders.Remove(collision.gameObject);
        }
    }
    void Start () {
        mine = this.GetComponent<SpriteRenderer>();
        shadows = shadow.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        intervalc--;
        grounded = (grounders.Count > 0);
        //transform.rotation = Quaternion.Euler(0, transform.rotation.y, 0);
        this.transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        if (victory)
        {

        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            if (intervalc < 0)
            {
                Instantiate(bullet, new Vector3(transform.position.x, transform.position.y+0.35f, 1), Quaternion.Euler(0, 0, 90));
                intervalc = interval;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(this.transform.right * 4 * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 0, 0);
                mine.enabled = false;
                shadows.enabled = true;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(transform.right * -4 * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 180, 0);
                mine.enabled = false;
                shadows.enabled = true;
            }
            else
            {
                mine.enabled = true;
                shadows.enabled = false;
            }
            if ((Input.GetKeyDown(KeyCode.W)) && grounded)
            {
                this.GetComponent<Rigidbody2D>().AddForce(transform.up * 500);
            }
        }
    }
}
