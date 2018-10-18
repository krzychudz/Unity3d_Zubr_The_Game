using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficultLevel : MonoBehaviour {

    public float bootleSpeedFactor; // o ile będzie zwiększana prędkość spadania
    public float spawnTimeFactor;   // o ile będzie zmniejszany czas do koljengo spawnu
    public float paddleSpeedFactor; // o ile zwiekszamy predkosc wozka

	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {

        if(globalVariables.Score % 100 == 0 && globalVariables.Score != 0 && globalVariables.bootleSpawnTime >= 1.2f)
        {
            if (globalVariables.updateGameDifficultLevel)
            {
                globalVariables.bootleMovementSpeed += bootleSpeedFactor;
                globalVariables.bootleSpawnTime -= spawnTimeFactor;
                globalVariables.paddleSpeed += paddleSpeedFactor;

                globalVariables.updateGameDifficultLevel = false;
            }

        }
		
	}

}
