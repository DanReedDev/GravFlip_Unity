using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Revive : MonoBehaviour
{
    public float next;
    int last;
    int difficutly;

    SpriteRenderer spriteRenderer;

    int isReviveActive;
    bool isReviveOn;

    public GameObject player;
    public GameObject spawnPoint;
    public GameObject revivePlatforms;
    public GameObject playerFollower;
    public GameObject enemyDestoryer;
    public PlayerController thePlayer;
    public ScreenFlash screenFlash;

    AudioSource audioSource;

    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        gameObject.GetComponent<Collider2D>().enabled = false;
        this.spriteRenderer.enabled = false;
        isReviveActive = PlayerPrefs.GetInt("IsSlowMoActive");
        audioSource = GetComponent<AudioSource>();
        thePlayer = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (isReviveActive == 1)
        {
            if (isReviveOn == false)
            {
                    gameObject.GetComponent<Collider2D>().enabled = true;
                    this.spriteRenderer.enabled = true;
                    isReviveOn = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            screenFlash.DoScreenFlash();
            audioSource.Play();
            Destroy(other.gameObject);
            revivePlatforms.SetActive(true);
            enemyDestoryer.SetActive(true);
            Destroy(enemyDestoryer, 1f);
            Destroy(spawnPoint, 2f);
            Destroy(playerFollower.GetComponent<FollowPlayer>());
            player.transform.localPosition = spawnPoint.transform.localPosition;
            gameObject.GetComponent<Collider2D>().enabled = false;
            this.spriteRenderer.enabled = false;
            isReviveOn = true;
            StartCoroutine(Wait());
        }

        if (other.gameObject.CompareTag("OutOfBounds"))
        {
            screenFlash.DoScreenFlash();
            audioSource.Play();
            revivePlatforms.SetActive(true);
            enemyDestoryer.SetActive(true);
            Destroy(enemyDestoryer, 1f);
            Destroy(spawnPoint, 2f);
            Destroy(playerFollower.GetComponent<FollowPlayer>());
            player.transform.localPosition = spawnPoint.transform.localPosition;
            gameObject.GetComponent<Collider2D>().enabled = false;
            this.spriteRenderer.enabled = false;
            isReviveOn = true;   
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        //Debug.Log("Waiting for Seconds...");
        thePlayer.movespeed = 0;
        thePlayer.GetComponent<Rigidbody2D>().gravityScale = 0;
        yield return new WaitForSeconds(2f);
        //Debug.Log("Finished Waiting");
        screenFlash.DoUnScreenFlash();
        difficutly = PlayerPrefs.GetInt("Difficutly");
        if (difficutly == 0)
        {
            thePlayer.movespeed = 10;
        }
        else if (difficutly == 1)
        {
            thePlayer.movespeed = 12;
        }
        else
        {
            thePlayer.movespeed = 16;
        }
        thePlayer.GetComponent<Rigidbody2D>().gravityScale = 8;
    }
}
