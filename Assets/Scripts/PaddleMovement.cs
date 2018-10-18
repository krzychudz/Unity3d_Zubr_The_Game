using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaddleMovement : MonoBehaviour {

    public GameObject paddle;

    public Image leftButton;
    public Image rightButton;

    public GameObject wheel1;
    public GameObject wheel2;

    Rigidbody2D paddleRigidBody;

    bool left = false;
    bool right = false;

    // Use this for initialization
    void Start () {
      
        paddleRigidBody = paddle.GetComponent<Rigidbody2D>();
	}


    public void LeftButtonDown()
    {
        left = true;
        leftButton.transform.localScale -= new Vector3(0.2f, 0.2f, 0);
    }

    public void RightButtonDown()
    {
        right = true;
        rightButton.transform.localScale -= new Vector3(0.2f, 0.2f, 0);
    }

    public void LeftButtonUp()
    {
        left = false;
        leftButton.transform.localScale += new Vector3(0.2f, 0.2f, 0);
    }

    public void RightButtonUp()
    {
        right = false;
        rightButton.transform.localScale += new Vector3(0.2f, 0.2f, 0);
    }
	
	// Update is called once per frame
	void Update () {
      
        if(left)
        {
            Vector3 dir = new Vector3(-1,0,0);
            paddleRigidBody.transform.Translate(dir * Time.deltaTime * globalVariables.paddleSpeed);

            wheel1.transform.Rotate(new Vector3(0, 0, 1), globalVariables.paddleSpeed);
            wheel2.transform.Rotate(new Vector3(0, 0, 1), globalVariables.paddleSpeed);

       
        }

        if(right)
        {
            Vector3 dir = new Vector3(1,0,0);
            paddleRigidBody.transform.Translate(dir * Time.deltaTime * globalVariables.paddleSpeed);

            wheel1.transform.Rotate(new Vector3(0, 0, 1), -globalVariables.paddleSpeed);
            wheel2.transform.Rotate(new Vector3(0, 0, 1), -globalVariables.paddleSpeed);
        }

    }
}
