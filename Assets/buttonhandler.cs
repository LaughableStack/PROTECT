using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonhandler : MonoBehaviour {
    public void navselect()
    {
        SceneManager.LoadScene("Select", LoadSceneMode.Single);
    }
    public void nav3()
    {
        SceneManager.LoadScene("LevThree", LoadSceneMode.Single);
    }
    public void nav2()
    {
        SceneManager.LoadScene("LevTwo", LoadSceneMode.Single);
    }
    public void nav1()
    {
        SceneManager.LoadScene("LevOne", LoadSceneMode.Single);
    }
    public void nav4()
    {
        SceneManager.LoadScene("LevFour", LoadSceneMode.Single);
    }
    public void nav5()
    {
        SceneManager.LoadScene("LevFive", LoadSceneMode.Single);
    }
    public void nav6()
    {
        SceneManager.LoadScene("LevSix", LoadSceneMode.Single);
    }
    public void nav7()
    {
        SceneManager.LoadScene("LevSeven", LoadSceneMode.Single);
    }
    public void nav8()
    {
        SceneManager.LoadScene("LevEight", LoadSceneMode.Single);
    }
    public void nav9()
    {
        SceneManager.LoadScene("LevNine", LoadSceneMode.Single);
    }
    public void nav0()
    {
        SceneManager.LoadScene("LevTen", LoadSceneMode.Single);
    }
    public void navm()
    {
        SceneManager.LoadScene("Thirst", LoadSceneMode.Single);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
