using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public GameObject adScreen;
    private ScoreManager theScoreManager;
    int chance;
    int coins;

    void Start()
    {
        gameObject.SetActive(false);
        theScoreManager = FindObjectOfType<ScoreManager>();
        chance = Random.Range(1, 100);
    }

    void Update()
    {
        coins = (int)theScoreManager.currentCoinCount;
        if (coins > 0 && chance >= 40)
        {
            adScreen.SetActive(true);
        }
        else if (coins > 0 && chance <= 39)
        {
            adScreen.SetActive(false);
        }
        else if (coins == 0)
        {
            adScreen.SetActive(false);
        }
    }

    public void ToggleDeathScreen ()
    {
        gameObject.SetActive(true);
        transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(gameObject, new Vector3(1f, 1f, 1f), 0.5f).setDelay(0f).setEaseOutBounce();
    }

    public void Replay ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ToMenu ()
    {
        SceneManager.LoadScene("Menu");
    }

}
