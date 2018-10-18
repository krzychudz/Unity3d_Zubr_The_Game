using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class globalVariables : MonoBehaviour {

    public static int Score;
    public static int Lives;
    public static float bootleMovementSpeed;
    public static float bootleSpawnTime;
    public static float paddleSpeed;

    public static bool updateGameDifficultLevel;
    public static bool showSpeedUpText;
    public static bool showExtraLiveText;

    bool isGame = true;

	// Use this for initialization
	void Start () {
        Score = 0;
        Lives = 3;
        bootleMovementSpeed = 5;
        bootleSpawnTime = 3;
        updateGameDifficultLevel = true;
        paddleSpeed = 5.0f;

        showExtraLiveText = false;
        showSpeedUpText = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (globalVariables.Lives == 0 && isGame)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScreen");

            isGame = false;
        }



    }
}
