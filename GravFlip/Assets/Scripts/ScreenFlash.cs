using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFlash : MonoBehaviour
{
    public void DoScreenFlash()
    {
        StartCoroutine(FlashScreen());
    }

    public void DoUnScreenFlash()
    {
        StartCoroutine(UnFlashScreen());
    }

    IEnumerator FlashScreen()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        for (float f = 0; f <= 1f; f += Time.deltaTime)
        {
            canvasGroup.alpha = Mathf.Lerp(0f, 1f, f / .03f);
            yield return null;
        }
        canvasGroup.alpha = 1;
    }

    IEnumerator UnFlashScreen()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 0.5f;
            yield return null;
        }
        canvasGroup.alpha = 0;
    } 
}
