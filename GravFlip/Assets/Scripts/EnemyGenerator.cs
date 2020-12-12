using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject theEnemy;
    public Transform generationPoint;
    public float distanceBetween;

    int difficulty;

    private float platformWidth;
    private float enemyWidth;

    private float distanceBetweenMin;
    private float distanceBetweenMax;

    void Start()
    {     
        platformWidth = theEnemy.GetComponent<BoxCollider2D>().size.x;
    }


    void Update()
    {

        if (transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

            Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, 2.1f);
            if (enemies.Length > 0)
            {

            }
            else
            {
                Instantiate(theEnemy, transform.position, transform.rotation);
            }

        }

        difficulty = PlayerPrefs.GetInt("Difficutly");
        if (difficulty == 0)
        {
            distanceBetweenMin = 10;
            distanceBetweenMax = 30;
        }
        else if (difficulty == 1)
        {
            distanceBetweenMin = 10;
            distanceBetweenMax = 20;
        }
        else
        {
            distanceBetweenMin = 8;
            distanceBetweenMax = 10;
        }

    }
}
