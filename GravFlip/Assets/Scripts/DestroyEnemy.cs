using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{

    public GameObject laser;
    public GameObject laserSpawn;
    Vector2 laserPos;
    public float nextFire;
    int lastFire;

    void Start()
    {

    }

    void Update()
    {
            lastFire = UnityEngine.Random.Range(0, 0);
            if (Time.time > nextFire)
            {
                nextFire = Time.time + lastFire;
                Fire();
            }
    }

    void Fire()
    {
        laserPos = transform.position;
        laserPos = laserSpawn.transform.position;
        Instantiate(laser, laserPos, Quaternion.identity);

    }

}
