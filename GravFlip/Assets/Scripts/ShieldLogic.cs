using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldLogic : MonoBehaviour
{
    public CameraController cameraController;

    public float next;
    int last;

    AudioSource audioSourceOn;
    AudioSource audioSourceOff;

    SpriteRenderer spriteRenderer;

    public GameObject player;

    int isShieldActive;
    bool isShieldOn;

    void Start()
    {
        AudioSource[] audios = GetComponents<AudioSource>();
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        audioSourceOn = audios[0];
        audioSourceOff = audios[1];
        gameObject.GetComponent<Collider2D>().enabled = false;
        this.spriteRenderer.enabled = false;
        isShieldActive = PlayerPrefs.GetInt("IsShieldActive");
    }

    void Update()
    {
        if (isShieldActive == 1)
        {
            if (isShieldOn == false)
            {
                last = UnityEngine.Random.Range(25, 30);
                if (Time.time > next)
                {
                    next = Time.time + last;
                    audioSourceOn.Play();
                    gameObject.GetComponent<Collider2D>().enabled = true;
                    this.spriteRenderer.enabled = true;
                    isShieldOn = true;
                }
            }
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            audioSourceOff.Play();
            StartCoroutine(cameraController.Shake(.15f, .3f));
            Destroy(other.gameObject);
            gameObject.GetComponent<Collider2D>().enabled = false;
            this.spriteRenderer.enabled = false;
            isShieldOn = false;
        }
    }
}
