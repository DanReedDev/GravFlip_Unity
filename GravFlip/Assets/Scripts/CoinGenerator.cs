using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject theCoin;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;
    private float enemyWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    void Start()
    {
       
        platformWidth = theCoin.GetComponent<BoxCollider2D>().size.x;

    }


    void Update()
    {

        if (transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

            Instantiate(theCoin, transform.position, transform.rotation);
        }

    }
}
