using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelScript : MonoBehaviour {
    public List<GameObject> texts;
    public void navlevel1()
    {
        SceneManager.LoadScene("LevOne", LoadSceneMode.Single);
    }
    public void navlevel2()
    {
        if (GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L1"))
        {
            SceneManager.LoadScene("LevTwo", LoadSceneMode.Single);
        }
    }
    public void navlevel3()
    {
        if (GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L2"))
        {
            SceneManager.LoadScene("LevThree", LoadSceneMode.Single);
        }
    }
    public void navlevel4()
    {
        if (GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L3"))
        {
            SceneManager.LoadScene("LevFour", LoadSceneMode.Single);
        }
    }
    public void navlevel5()
    {
        if (GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L4"))
        {
            SceneManager.LoadScene("LevFive", LoadSceneMode.Single);
        }
    }
    public void navlevel6()
    {
        if (GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L5"))
        {
            SceneManager.LoadScene("LevSix", LoadSceneMode.Single);
        }
    }
    public void navlevel7()
    {
        if (GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L6"))
        {
            SceneManager.LoadScene("LevSeven", LoadSceneMode.Single);
        }
    }
    public void navlevel8()
    {
        if (GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L7"))
        {
            SceneManager.LoadScene("LevEight", LoadSceneMode.Single);
        }
    }
    public void navlevel9()
    {
        if (GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L8"))
        {
            SceneManager.LoadScene("LevNine", LoadSceneMode.Single);
        }
    }
    public void navlevel10()
    {
        if (GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L9"))
        {
            SceneManager.LoadScene("LevTen", LoadSceneMode.Single);
        }
    }
    // Use this for initialization
    void Start () {
        if (!GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L1"))
        {
            texts[1].GetComponent<Text>().text = "Locked";
        }
        if (!GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L2"))
        {
            texts[2].GetComponent<Text>().text = "Locked";
        }
        if (!GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L3"))
        {
            texts[3].GetComponent<Text>().text = "Locked";
        }
        if (!GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L4"))
        {
            texts[4].GetComponent<Text>().text = "Locked";
        }
        if (!GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L5"))
        {
            texts[5].GetComponent<Text>().text = "Locked";
        }
        if (!GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L6"))
        {
            texts[6].GetComponent<Text>().text = "Locked";
        }
        if (!GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L7"))
        {
            texts[7].GetComponent<Text>().text = "Locked";
        }
        if (!GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L8"))
        {
            texts[8].GetComponent<Text>().text = "Locked";
        }
        if (!GameObject.FindGameObjectWithTag("Librarian").GetComponent<Lscript>().levelsDone.Contains("L9"))
        {
            texts[9].GetComponent<Text>().text = "Locked";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
