using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkGrow : MonoBehaviour
{

    Vector3 maxScale;

    public Vector3 minScale;
    public bool repeatable;
    public float speed = 6;
    public float duration = 2f;

    float lerpDuration = 6f;
    float startValue = 1f;
    float endValue = .2f;
    float valueToLerp;

    int isShrinkEnemiesActive;

    public float next;
    int last;
    public CameraController cameraController;

    AudioSource audioSource1;
    AudioSource audioSource2;

    public void Start()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
        isShrinkEnemiesActive = PlayerPrefs.GetInt("IsShrinkActive");
        AudioSource[] audios = GetComponents<AudioSource>();
        audioSource1 = audios[0];
        audioSource2 = audios[1];
    }

    public void Update()
    {
        if (isShrinkEnemiesActive == 1)
        {
            last = UnityEngine.Random.Range(10, 10);
            if (Time.time > next)
            {
                next = Time.time + last;
                StartCoroutine(Shrink());
                audioSource2.Play();
                StartCoroutine(cameraController.Shake(.15f, .3f));
                //Debug.Log("Enemies Shrinking...");
                StartCoroutine(Grow());
                //Debug.Log("Enemies Growing...");
            }
        }
    }

    IEnumerator Shrink()
    {
        float timeElapsed = 0f;
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;
            
            yield return transform.localScale = new Vector3(valueToLerp, valueToLerp, 1f);
        }
        valueToLerp = endValue;
    }

    IEnumerator Grow()
    {
        float timeElapsed = 0f;
        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(endValue, startValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;

            yield return transform.localScale = new Vector3(valueToLerp, valueToLerp, 1f);
        }
        valueToLerp = startValue;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
    }

}
