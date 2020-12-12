using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    public float next;
    int last;

    public float slowDownFactor = 0.05f;
    public float slowDownLength = 6f;

    int isSlowMotionActive;

    AudioSource audioSource;

    void Start()
    {
        audioSource= GetComponent<AudioSource>();
        isSlowMotionActive = PlayerPrefs.GetInt("IsSlowMoActive");
        if (isSlowMotionActive == 1)
        {
            StartCoroutine(ActivateSlowMotion());
        }
    }

    void Update()
    {
        Time.timeScale += (1f / slowDownLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    public void DoSlowMotion()
    {
        audioSource.Play();
        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }

    IEnumerator ActivateSlowMotion()
    {
        for (; ; )
        {
            yield return new WaitForSeconds(10f);
            DoSlowMotion();
        }
    }

}
