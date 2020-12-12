using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour
{

    public GameObject laser;
    public GameObject laserSpawn;
    Vector2 laserPos;
    public float nextFire;
    int lastFire;
    public CameraController cameraController;
    AudioSource audioSource;
    int isLaserActive;

    void Start()
    {
        isLaserActive = PlayerPrefs.GetInt("IsLaserActive");
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (isLaserActive == 1)
        {
            lastFire = UnityEngine.Random.Range(10, 18);
            if (Time.time > nextFire)
            {
                nextFire = Time.time + lastFire;
                audioSource.Play();
                Fire();
            }
        }
    }

    void Fire()
    {
        laserPos = transform.position;
        laserPos = laserSpawn.transform.position;
        Instantiate(laser, laserPos, Quaternion.identity);
        //StartCoroutine(cameraController.Shake(.15f, .3f));
    }

}
