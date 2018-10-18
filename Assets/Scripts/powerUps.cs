using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUps : MonoBehaviour {

    public Text LivesText;
    bool speedUp = false;

    public float speedUpDuration;
    public float speedUpPower;

    // Use this for initialization
    void Start () {



	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "paddle")
        {
            
            int i = Random.Range(0, 2);

            if(i == 0) // Dodanie zycia
            {
                globalVariables.Lives++;
                LivesText.text = "Lives: " + globalVariables.Lives.ToString();
                Destroy(gameObject);

                globalVariables.showExtraLiveText = true;
            }
            else // Przyspieszenie wozka
            {
                globalVariables.paddleSpeed = globalVariables.paddleSpeed * speedUpPower;
                Destroy(gameObject, speedUpDuration);
                speedUp = true;
                gameObject.transform.SetPositionAndRotation(new Vector3(-10, -10, 0), Quaternion.identity);

                globalVariables.showSpeedUpText = true;
            }


        }

        if (collision.gameObject.name == "DownCollider")
        {
            if(!speedUp)
                Destroy(gameObject);
        }

    }

    void OnDestroy()
    {
        if (speedUp)
        {
            globalVariables.paddleSpeed = globalVariables.paddleSpeed / speedUpPower;
            speedUp = false;
        }
    }

}
