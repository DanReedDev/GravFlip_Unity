using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{

    private ScoreManager theScoreManager;

    public GameObject thePlatform;
    public Transform generationPoint;
    private float distanceBetween;

    private float platformWidth;

    public float scoreCount;

    private float distanceBetweenMin;
    private float distanceBetweenMax;

    public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformWidths;

    int difficulty;

    void Start()
    {
        //platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;

        platformWidths = new float[thePlatforms.Length];

        for (int i = 0; i < thePlatforms.Length; i ++)
        {
            platformWidths[i] = thePlatforms[i].GetComponent<BoxCollider2D>().size.x;
        }
    }

    
    void Update()
    {

            if (transform.position.x < generationPoint.position.x)
            {
                distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

                platformSelector = Random.Range(0, thePlatforms.Length);

                transform.position = new Vector3(transform.position.x + platformWidths[platformSelector] + distanceBetween, transform.position.y, transform.position.z);

                Instantiate(/*thePlatform*/ thePlatforms[platformSelector], transform.position, transform.rotation);
            }

        if (scoreCount > 500)
        {
            if (transform.position.x < generationPoint.position.x)
            {
                distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

                platformSelector = Random.Range(0, thePlatforms.Length);

                transform.position = new Vector3(transform.position.x + platformWidths[platformSelector] + (distanceBetween + 5), transform.position.y, transform.position.z);

                Instantiate(/*thePlatform*/ thePlatforms[platformSelector], transform.position, transform.rotation);
            }
        }

        difficulty = PlayerPrefs.GetInt("Difficutly");
        if (difficulty == 0)
        {
            distanceBetweenMin = 5;
            distanceBetweenMax = 9;
        }
        else if (difficulty == 1)
        {
            distanceBetweenMin = 6;
            distanceBetweenMax = 10;
        }
        else
        {
            distanceBetweenMin = 6;
            distanceBetweenMax = 10;
        }

    }
}
