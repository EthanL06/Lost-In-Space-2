//create a script that makes a turret shoot at the player
//then the turret stops shooting after a set amount of time
//then the turret starts shooting again after a set amount of time

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float time;
    public float shootTime;
    public float stopTime;
    public GameObject bullet;
    public Transform shotPoint;
    private bool shoot;
    private bool stop;
    private float timer;
    private float shootTimer;
    private float stopTimer;

    // Start is called before the first frame update
    void Start()
    {
        shoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (shoot)
        {
            shootTimer += Time.deltaTime;
            if (shootTimer > shootTime)
            {
                Instantiate(bullet, shotPoint.position, shotPoint.rotation);
                shootTimer = 0;
                shoot = false;
                stop = true;
            }
        }

        if (stop)
        {
            stopTimer += Time.deltaTime;
            if (stopTimer > stopTime)
            {
                stopTimer = 0;
                stop = false;
                shoot = true;
            }
        }
    }
}

