using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowInfo : MonoBehaviour {

    public Text speedUpText;
    public Text extraLiveText;

    public float textDuration;
    float textDurationTmp;

	// Use this for initialization
	void Start () {

        speedUpText.enabled = false;
        extraLiveText.enabled = false;

        textDurationTmp = textDuration;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(globalVariables.showSpeedUpText)
        {
            speedUpText.enabled = true;

            textDuration -= Time.deltaTime;

            speedUpText.transform.Rotate(new Vector3(0, 0, 1), 3);

            if (textDuration <= 0)
            {
                globalVariables.showSpeedUpText = false;
                speedUpText.enabled = false;
                textDuration = textDurationTmp;

                speedUpText.transform.rotation = Quaternion.identity;
            }

  
        }

        if(globalVariables.showExtraLiveText)
        {
            extraLiveText.enabled = true;

            textDuration -= Time.deltaTime;

            extraLiveText.transform.Rotate(new Vector3(0, 0, 1), -3);

            if (textDuration <= 0)
            {
                globalVariables.showExtraLiveText = false;
                extraLiveText.enabled = false;
                textDuration = textDurationTmp;

                extraLiveText.transform.rotation = Quaternion.identity;
            }
        }


	}
}
