using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public Text scoreText;
    public Text hiScoreText;
    public Text deathCountText;
    public Text previousScoreText;
    public Text coinText;
    public Text currentCoinText;
    public Text deathScreen;

    public Text easyHiScore;
    public Text medHiScore;
    public Text hardHiScore;
    public float easyScoreCount;
    public float medScoreCount;
    public float hardScoreCount;
    public float easyHiScoreCount;
    public float medHiScoreCount;
    public float hardHiScoreCount;

    int difficulty;

    public float scoreCount;
    public float hiScoreCount;
    public float previousScoreCount;

    public int coinCount;
    public float currentCoinCount;
    public int hiCoinCount;
    public int deathCount;
    public int hiDeathCount;

    public float pointsPerSecond;
    
    public bool scoreIncreasing;


    void Start()
    {

        if(instance == null)
        {

            instance = this;

        }

        difficulty = PlayerPrefs.GetInt("Difficutly");

        if (PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }

        if (PlayerPrefs.HasKey("DeathCount"))
        {
            deathCount = PlayerPrefs.GetInt("DeathCount");
        }

        if (PlayerPrefs.HasKey("PreviousScore"))
        {
            previousScoreCount = PlayerPrefs.GetFloat("PreviousScore");
        }

        if (PlayerPrefs.HasKey("CoinCount"))
        {
            coinCount = PlayerPrefs.GetInt("CoinCount");
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

        if (difficulty == 0)
        {
            easyHiScore.gameObject.SetActive(true);
        } 
        else if (difficulty == 1)
        {
            medHiScore.gameObject.SetActive(true);
        }
        else if (difficulty == 2)
        {
            hardHiScore.gameObject.SetActive(true);
        }

        currentCoinCount = 0;

    }

    void Update()
    {

        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if (scoreIncreasing && difficulty == 0)
        {
            easyScoreCount += pointsPerSecond * Time.deltaTime;
        }

        else if (scoreIncreasing && difficulty == 1)
        {
            medScoreCount += pointsPerSecond * Time.deltaTime;
        }
        else if (scoreIncreasing && difficulty == 2)
        {
            hardScoreCount += pointsPerSecond * Time.deltaTime;
        }

        if(deathCount > hiDeathCount)
        {

            hiDeathCount = deathCount;
            PlayerPrefs.SetInt("DeathCount", hiDeathCount);

        }

        if (!scoreIncreasing)
        {

            previousScoreCount = scoreCount;
            PlayerPrefs.SetFloat("PreviousScore", scoreCount);

        }

        if (coinCount > hiCoinCount)
        {
            hiCoinCount = coinCount;
            PlayerPrefs.SetInt("CoinCount", coinCount);
        }

        if (difficulty == 0 && easyScoreCount > easyHiScoreCount)
        {
            easyHiScoreCount = easyScoreCount;
            PlayerPrefs.SetFloat("EasyHiScore", easyHiScoreCount);
        } 
        else if (difficulty == 1 && medScoreCount > medHiScoreCount)
        {
            medHiScoreCount = medScoreCount;
            PlayerPrefs.SetFloat("MedHiScore", medHiScoreCount);
        } 
        else if (difficulty == 2 && hardScoreCount > hardHiScoreCount)
        {
            hardHiScoreCount = hardScoreCount;
            PlayerPrefs.SetFloat("HardHiScore", hardHiScoreCount);
        } 
        else
        {
            
        }

        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        hiScoreText.text = "High Score: " + Mathf.Round (hiScoreCount);
        coinText.text = "x " + coinCount.ToString();
        currentCoinText.text = Mathf.Round(currentCoinCount * 1.2f).ToString() + " Coins!";
        deathCountText.text = "Deaths: " + deathCount;
        deathScreen.text = "Score: " + Mathf.Round(scoreCount);

        easyHiScore.text = "High Score: " + Mathf.Round(easyHiScoreCount);
        medHiScore.text = "High Score: " + Mathf.Round(medHiScoreCount);
        hardHiScore.text = "High Score: " + Mathf.Round(hardHiScoreCount);

    }

    public void ChangeCoinCount(int coinValue)
    {
        coinCount += coinValue;
        coinText.text = "x" + coinCount.ToString();
    }

    public void ChangeCurrentCoinCount(int coinValue)
    {
        currentCoinCount += coinValue;
        currentCoinText.text = Mathf.Round(currentCoinCount * 1.2f).ToString() + " Coins!";
    }

    public void Death ()
    {
        scoreIncreasing = false;
    }
}
