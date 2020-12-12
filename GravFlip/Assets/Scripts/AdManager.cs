using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour, IUnityAdsListener
{

    string GooglePlay_ID = "3884195";
    bool GameMode = false;
    string myPlacementId = "rewardedVideo";

    private ScoreManager theScoreManager;
    int coinCount;

    public GameObject adPopUp;


    // Start is called before the first frame update
    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(GooglePlay_ID, GameMode);
        theScoreManager = FindObjectOfType<ScoreManager>();
        coinCount = PlayerPrefs.GetInt("CoinCount");
    }

    // Update is called once per frame
    public void ShowInterstitislAD()
    {
            Advertisement.Show();
    }

    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            // Reward the user for watching the ad to completion.
            theScoreManager.coinCount += (int)Mathf.Round(theScoreManager.currentCoinCount * 1.2f);
            PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
            //Debug.LogWarning("You got a reward of " + Mathf.Round(theScoreManager.currentCoinCount * 1.2f) + " coins!");
            Destroy(adPopUp);
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
            Debug.LogWarning("You did not get a reward.");
            adPopUp.SetActive(false);
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
            adPopUp.SetActive(false);
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
            // Optional actions to take when the placement becomes ready(For example, enable the rewarded ads button)
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }

    public void CloseAd()
    {
        LeanTween.scale(adPopUp, new Vector3(0f, 0f, 0f), 0.2f).setDelay(0f).setOnComplete(DestroyMe);
    }

    public void DestroyMe()
    {
        adPopUp.SetActive(false);
    }
}
