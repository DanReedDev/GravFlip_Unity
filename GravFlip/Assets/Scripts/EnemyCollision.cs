using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private Transform player;

    private ScoreManager theScoreManager;
    public DeathScreen deathScreen;
    public PlayerController playerController;
    public CameraController cameraController;

    AudioSource audioSource;

    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        { 
            audioSource.Play();
            theScoreManager.deathCount = theScoreManager.deathCount + 1;
            PlayerPrefs.SetInt("DeathCount", theScoreManager.deathCount);
            StartCoroutine(cameraController.Shake(.15f, .3f));
            theScoreManager.previousScoreCount = theScoreManager.scoreCount;
            PlayerPrefs.SetFloat("PreviousScore", theScoreManager.scoreCount);
            deathScreen.ToggleDeathScreen();
            theScoreManager.Death();
            playerController.PlayerDeath();
        }
    }
}
