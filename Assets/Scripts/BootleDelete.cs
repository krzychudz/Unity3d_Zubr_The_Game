using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BootleDelete : MonoBehaviour {

    public Text ScoreText;
    public Text LivesText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "paddle")
        {
            Destroy(gameObject);
            globalVariables.Score += 10;
            ScoreText.text = "Score: " + globalVariables.Score.ToString();

            globalVariables.updateGameDifficultLevel = true;
        }

        if(collision.gameObject.name == "DownCollider")
        {
            Destroy(gameObject);
            globalVariables.Lives -= 1;
            LivesText.text = "Lives: " + globalVariables.Lives.ToString();
        }
    }

}
