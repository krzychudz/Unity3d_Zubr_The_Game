using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour {

    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint2p;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public GameObject bootle1;
    public GameObject bootle2;
    public GameObject powerUp;

    public float powerUpSpawnTime;

    float spawnTime;
    float tmp;
    float tmpPowerUpSpawnTime;


	// Use this for initialization
	void Start () {
        spawnTime = globalVariables.bootleSpawnTime;
        tmp = spawnTime;

        tmpPowerUpSpawnTime = powerUpSpawnTime;

	}
	
	// Update is called once per frame
	void Update () {

            tmp = globalVariables.bootleSpawnTime;

            spawnTime -= Time.deltaTime;
            powerUpSpawnTime -= Time.deltaTime;


        if(spawnTime <= 0)
        {
            SpawnBootle(bootle1, bootle2);

            spawnTime = tmp;

        }

        if(powerUpSpawnTime <= 0)
        {
            SpawnBootle(powerUp, powerUp);

            powerUpSpawnTime = tmpPowerUpSpawnTime;
        }




	}

    void SpawnBootle(GameObject bootle1, GameObject bootle2)
    {
        int i = Random.Range(1, 6);

        if (i == 1)
        {
            int j = Random.Range(1, 3);

            if (j == 1)
            {
                var tmp = (GameObject)Instantiate(bootle1, spawnPoint1.position, spawnPoint1.rotation);
            }
            else
            {
                var tmp = (GameObject)Instantiate(bootle2, spawnPoint1.position, spawnPoint1.rotation);
            }
        }
        else if (i == 2)
        {
            int j = Random.Range(1, 3);

            if (j == 1)
            {
                var tmp = (GameObject)Instantiate(bootle1, spawnPoint2.position, spawnPoint2.rotation);
            }
            else
            {
                var tmp = (GameObject)Instantiate(bootle2, spawnPoint2.position, spawnPoint2.rotation);
            }
        }
        else if (i == 3)
        {
            int j = Random.Range(1, 3);

            if (j == 1)
            {
                var tmp = (GameObject)Instantiate(bootle1, spawnPoint3.position, spawnPoint3.rotation);
            }
            else
            {
                var tmp = (GameObject)Instantiate(bootle2, spawnPoint3.position, spawnPoint3.rotation);
            }
        }
        else if (i == 4)
        {
            int j = Random.Range(1, 3);

            if (j == 1)
            {
                var tmp = (GameObject)Instantiate(bootle1, spawnPoint4.position, spawnPoint4.rotation);
            }
            else
            {
                var tmp = (GameObject)Instantiate(bootle2, spawnPoint4.position, spawnPoint4.rotation);
            }
        }
        else if (i == 5)
        {
            int j = Random.Range(1, 3);

            if (j == 1)
            {
                var tmp = (GameObject)Instantiate(bootle1, spawnPoint2p.position, spawnPoint2p.rotation);
            }
            else
            {
                var tmp = (GameObject)Instantiate(bootle2, spawnPoint2p.position, spawnPoint2p.rotation);
            }
        }

    }

}
