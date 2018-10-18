using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour {

    public Text PointsInfo;

	// Use this for initialization
	void Start () {
        PointsInfo.text = "Your score: " + globalVariables.Score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MainMenuClicked()
    {
       SceneManager.LoadScene("titleScreen");
    }

    public void ExitClicked()
    {
        Application.Quit();
    }
}
