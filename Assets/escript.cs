using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escript : MonoBehaviour {
    public GameObject shadow;
    public float rot = 0;
    public bool dead = false;
    // Use this for initialization
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            Debug.Log("touch");
            if (rot == 180)
            {
                rot = 0;
            } else
            {
                rot = 180;
            }
            transform.rotation = Quaternion.Euler(0, rot, 0);
        }
        else if (collision.CompareTag("Player") && !dead)
        {
            Debug.Log("attack");
            StartCoroutine(Example(collision.gameObject));
        }
    }

    IEnumerator Example(GameObject enemy)
    {
        yield return new WaitForSeconds(0.01f);
        if (!dead)
        {
            enemy.GetComponent<mscript>().game_end();
        }
    }
    public void die()
    {
            shadow.GetComponent<sscript>().die();
            Destroy(this);
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.rotation.y == 0)
        {
            transform.Translate(transform.right * -3 * Time.deltaTime);
        } else
        {
            transform.Translate(transform.right * 3 * Time.deltaTime);
        }
	}
}
