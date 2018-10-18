using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootleMovement : MonoBehaviour {

    float speed;
    Vector3 dir;
    Rigidbody2D rigidbody2d;

	// Use this for initialization
	void Start () {
        dir = new Vector3(0, -1, 0);
        rigidbody2d = GetComponent<Rigidbody2D>();
        speed = globalVariables.bootleMovementSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        rigidbody2d.transform.Translate(dir * speed * Time.deltaTime);
    }


}
