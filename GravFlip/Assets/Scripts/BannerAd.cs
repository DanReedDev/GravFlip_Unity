using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class BannerAd : MonoBehaviour
{
    string GooglePlay_ID = "3884195";
    string placementId = "banner";
    bool testMode = false;

    public string menu, game, backgrounds;

    IEnumerator Start()
    {
        Advertisement.Initialize(GooglePlay_ID, testMode);

        while (!Advertisement.IsReady(placementId))
            yield return null;

    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == menu)
        {
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Show(placementId);
        }
        else if (scene.name == game)
        {
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Hide();
        }
        else if (scene.name == backgrounds)
        {
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Hide();
        }
    }
}
