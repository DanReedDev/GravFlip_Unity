using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    private ScoreManager theScoreManager;

    public float hiScoreCount;
    public float easyHiScoreCount;
    public float medHiScoreCount;
    public float hardHiScoreCount;

    public int deathCount;
    public int coinCount;

    public Text hiScoreText;
    public Text easyHiScore;
    public Text medHiScore;
    public Text hardHiScore;
    public Text deathCountText;

    void Start()
    {

        theScoreManager = FindObjectOfType<ScoreManager>();

        if (PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }

        if (PlayerPrefs.HasKey("DeathCount"))
        {
            deathCount = PlayerPrefs.GetInt("DeathCount");
        }

        if (PlayerPrefs.HasKey("EasyHiScore"))
        {
            easyHiScoreCount = PlayerPrefs.GetFloat("EasyHiScore");
        }

        if (PlayerPrefs.HasKey("MedHiScore"))
        {
            medHiScoreCount = PlayerPrefs.GetFloat("MedHiScore");
        }

        if (PlayerPrefs.HasKey("HardHiScore"))
        {
            hardHiScoreCount = PlayerPrefs.GetFloat("HardHiScore");
        }
    }

    void Update()
    {

        easyHiScore.text = "High Score: " + Mathf.Round(easyHiScoreCount);
        medHiScore.text = "High Score: " + Mathf.Round(medHiScoreCount);
        hardHiScore.text = "High Score: " + Mathf.Round(hardHiScoreCount);

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }

    public void ResetGame()
    {
        Debug.Log("Game is resetting...");
        PlayerPrefs.DeleteAll();
        theScoreManager.coinCount -= theScoreManager.coinCount;
        theScoreManager.deathCount -= theScoreManager.deathCount;
    }

    public void ToBackgrounds()
    {
        SceneManager.LoadScene("Backgrounds");
    }

}
