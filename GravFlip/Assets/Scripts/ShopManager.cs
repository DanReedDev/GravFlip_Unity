using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{

    private ScoreManager theScoreManager;

    int coinCount;

    int isLaserSold;
    int isShrinkSold;
    int isSlowMoSold;
    int isShieldSold;

    int isRedCubeSold;
    int isBlueCubeSold;
    int isGreenCubeSold;
    int isPinkCubeSold;
    int isOrangeCubeSold;
    int isPurpleCubeSold;
    int isYellowCubeSold;
    int isWhiteCubeSold;
    int isBlackCubeSold;

    int isTigerSkinSold;
    int isCamoSkinSold;
    int isArticSkinSold;
    int isDesertSkinSold;
    int isCrateSkinSold;

    int isFireSkinSold;

    int isCitySold;
    int isLavaSold;
    int isForestSold;
    int isFutureSold;

    public Text laserPrice;
    public Text shrinkPrice;
    public Text slowMoPrice;
    public Text shieldPrice;

    public Text redCubeText;
    public Text blueCubeText;
    public Text greenCubeText;
    public Text pinkCubeText;
    public Text orangeCubeText;
    public Text purpleCubeText;
    public Text yellowCubeText;
    public Text whiteCubeText;
    public Text blackCubeText;

    public Text tigerSkinText;
    public Text camoSkinText;
    public Text articSkinText;
    public Text desertSkinText;
    public Text crateSkinText;

    public Text fireSkinText;

    public Text cityText;
    public Text lavaText;
    public Text forestText;
    public Text futureText;

    public Button buyLaser;
    public Button buyShrink;
    public Button buySlowMo;
    public Button buyShield;

    public Button buyRedCube;
    public Button buyBlueCube;
    public Button buyGreenCube;
    public Button buyPinkCube;
    public Button buyOrangeCube;
    public Button buyPurpleCube;
    public Button buyYellowCube;
    public Button buyWhiteCube;
    public Button buyBlackCube;

    public Button buyTigerSkin;
    public Button buyCamoSkin;
    public Button buyArticSkin;
    public Button buyDesertSkin;
    public Button buyCrateSkin;

    public Button buyFireSkin;

    public Button buyCity;
    public Button buyLava;
    public Button buyForest;
    public Button buyFuture;

    public int laserValue;
    public int shrinkValue;
    public int slowMoValue;
    public int shieldValue;

    public int redCubeValue;
    public int blueCubeValue;
    public int greenCubeValue;
    public int pinkCubeValue;
    public int orangeCubeValue;
    public int purpleCubeValue;
    public int yellowCubeValue;
    public int whiteCubeValue;
    public int blackCubeValue;

    public int tigerSkinValue;
    public int camoSkinValue;
    public int articSkinValue;
    public int desertSkinValue;
    public int crateSkinValue;

    public int fireSkinValue;

    public int cityValue;
    public int lavaValue;
    public int forestValue;
    public int futureValue;

    public Button purchase1;
    public Button purchase2;
    public Button purchase3;
    public Button purchase4;
    public Button purchase5;
    public Button purchase6;
    public Button purchase7;
    public Button purchase8;
    public Button purchase9;
    public Button purchase10;
    public Button purchase11;
    public Button purchase12;
    public Button purchase13;
    public Button purchase14;
    public Button purchase15;
    public Button purchase16;
    public Button purchase17;
    public Button purchase18;
    public Button purchase19;
    public Button purchase20;
    public Button purchase21;
    public Button purchase22;
    public Button purchase23;

    public Button purchase1b;
    public Button purchase2b;
    public Button purchase3b;
    public Button purchase4b;
    public Button purchase5b;
    public Button purchase6b;
    public Button purchase7b;
    public Button purchase8b;
    public Button purchase9b;
    public Button purchase10b;
    public Button purchase11b;
    public Button purchase12b;
    public Button purchase13b;
    public Button purchase14b;
    public Button purchase15b;
    public Button purchase16b;
    public Button purchase17b;
    public Button purchase18b;
    public Button purchase19b;
    public Button purchase20b;
    public Button purchase21b;
    public Button purchase22b;
    public Button purchase23b;

    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
        coinCount = PlayerPrefs.GetInt("CoinCount");
    }


    void Update()
    {
        //Laser
        isLaserSold = PlayerPrefs.GetInt("IsLaserSold");
        if (coinCount >= laserValue && isLaserSold == 0)
        {
            purchase1.gameObject.SetActive(true);
            buyLaser.interactable = true;
            laserPrice.text = (laserValue.ToString());
        } else
        {
            purchase1.gameObject.SetActive(false);
            buyLaser.interactable = false;
           laserPrice.text = (laserValue.ToString());
        }

        if (isLaserSold == 1)
        {
            buyLaser.interactable = false;
            laserPrice.text = "SOLD!";
            purchase1b.interactable = false;
        }
        else
        {
            purchase1b.interactable = true;
        }

        //Shrink
        isShrinkSold = PlayerPrefs.GetInt("IsShrinkSold");
        if (coinCount >= shrinkValue && isShrinkSold == 0)
        {
            purchase2.gameObject.SetActive(true);
            buyShrink.interactable = true;
            shrinkPrice.text = (shrinkValue.ToString());
        }
        else
        {
            purchase2.gameObject.SetActive(false);
            buyShrink.interactable = false;
            shrinkPrice.text = (shrinkValue.ToString());
        }

        if (isShrinkSold == 1)
        {
            buyShrink.interactable = false;
            shrinkPrice.text = "SOLD!";
            purchase2b.interactable = false;
        }
        else
        {
            purchase2b.interactable = true;
        }

        //SlowMo
        isSlowMoSold = PlayerPrefs.GetInt("IsSlowMoSold");
        if (coinCount >= slowMoValue && isSlowMoSold == 0)
        {
            purchase3.gameObject.SetActive(true);
            buySlowMo.interactable = true;
            slowMoPrice.text = (slowMoValue.ToString());
        }
        else
        {
            purchase3.gameObject.SetActive(false);
            buySlowMo.interactable = false;
            slowMoPrice.text = (slowMoValue.ToString());
        }

        if (isSlowMoSold == 1)
        {
            buySlowMo.interactable = false;
            slowMoPrice.text = "SOLD!";
            purchase3b.interactable = false;
        }
        else
        {
            purchase3b.interactable = true;
        }

        //Shield
        isShieldSold = PlayerPrefs.GetInt("IsShieldSold");
        if (coinCount >= shieldValue && isShieldSold == 0)
        {
            purchase4.gameObject.SetActive(true);
            buyShield.interactable = true;
            shieldPrice.text = (shieldValue.ToString());
        }
        else
        {
            purchase4.gameObject.SetActive(false);
            buyShield.interactable = false;
            shieldPrice.text = (shieldValue.ToString());
        }

        if (isShieldSold == 1)
        {
            buyShield.interactable = false;
            shieldPrice.text = "SOLD!";
            purchase4b.interactable = false;
        }
        else
        {
            purchase4b.interactable = true;
        }

        //RedCube
        isRedCubeSold = PlayerPrefs.GetInt("IsRedCubeSold");
        if (coinCount >= redCubeValue && isRedCubeSold == 0)
        {
            purchase5.gameObject.SetActive(true);
            buyRedCube.interactable = true;
            redCubeText.text = (redCubeValue.ToString());
        }
        else
        {
            purchase5.gameObject.SetActive(false);
            buyRedCube.interactable = false;
            redCubeText.text = (redCubeValue.ToString());
        }

        if (isRedCubeSold == 1)
        {
            buyRedCube.interactable = false;
            redCubeText.text = "SOLD!";
            purchase5b.interactable = false;
        }
        else
        {
            purchase5b.interactable = true;
        }

        //BlueCube
        isBlueCubeSold = PlayerPrefs.GetInt("IsBlueCubeSold");
        if (coinCount >= blueCubeValue && isBlueCubeSold == 0)
        {
            purchase6.gameObject.SetActive(true);
            buyBlueCube.interactable = true;
            blueCubeText.text = (blueCubeValue.ToString());
        }
        else
        {
            purchase6.gameObject.SetActive(false);
            buyBlueCube.interactable = false;
            blueCubeText.text = (blueCubeValue.ToString());
        }

        if (isBlueCubeSold == 1)
        {
            buyBlueCube.interactable = false;
            blueCubeText.text = "SOLD!";
            purchase6b.interactable = false;
        }
        else
        {
            purchase6b.interactable = true;
        }

        //GreenCube
        isGreenCubeSold = PlayerPrefs.GetInt("IsGreenCubeSold");
        if (coinCount >= greenCubeValue && isGreenCubeSold == 0)
        {
            purchase7.gameObject.SetActive(true);
            buyGreenCube.interactable = true;
            greenCubeText.text = (greenCubeValue.ToString());
        }
        else
        {
            purchase7.gameObject.SetActive(false);
            buyGreenCube.interactable = false;
            greenCubeText.text = (greenCubeValue.ToString());
        }

        if (isGreenCubeSold == 1)
        {
            buyGreenCube.interactable = false;
            greenCubeText.text = "SOLD!";
            purchase7b.interactable = false;
        }
        else
        {
            purchase7b.interactable = true;
        }

        //PinkCube
        isPinkCubeSold = PlayerPrefs.GetInt("IsPinkCubeSold");
        if (coinCount >= pinkCubeValue && isPinkCubeSold == 0)
        {
            purchase8.gameObject.SetActive(true);
            buyPinkCube.interactable = true;
            pinkCubeText.text = (pinkCubeValue.ToString());
        }
        else
        {
            purchase8.gameObject.SetActive(false);
            buyPinkCube.interactable = false;
            pinkCubeText.text = (pinkCubeValue.ToString());
        }

        if (isPinkCubeSold == 1)
        {
            buyPinkCube.interactable = false;
            pinkCubeText.text = "SOLD!";
            purchase8b.interactable = false;
        }
        else
        {
            purchase8b.interactable = true;
        }

        //OrangeCube
        isOrangeCubeSold = PlayerPrefs.GetInt("IsOrangeCubeSold");
        if (coinCount >= orangeCubeValue && isOrangeCubeSold == 0)
        {
            purchase9.gameObject.SetActive(true);
            buyOrangeCube.interactable = true;
            orangeCubeText.text = (orangeCubeValue.ToString());
        }
        else
        {
            purchase9.gameObject.SetActive(false);
            buyOrangeCube.interactable = false;
            orangeCubeText.text = (orangeCubeValue.ToString());
        }

        if (isOrangeCubeSold == 1)
        {
            buyOrangeCube.interactable = false;
            orangeCubeText.text = "SOLD!";
            purchase9b.interactable = false;
        }
        else
        {
            purchase9b.interactable = true;
        }

        //PurpleCube
        isPurpleCubeSold = PlayerPrefs.GetInt("IsPurpleCubeSold");
        if (coinCount >= purpleCubeValue && isPurpleCubeSold == 0)
        {
            purchase10.gameObject.SetActive(true);
            buyPurpleCube.interactable = true;
            purpleCubeText.text = (purpleCubeValue.ToString());
        }
        else
        {
            purchase10.gameObject.SetActive(false);
            buyPurpleCube.interactable = false;
            purpleCubeText.text = (purpleCubeValue.ToString());
        }

        if (isPurpleCubeSold == 1)
        {
            buyPurpleCube.interactable = false;
            purpleCubeText.text = "SOLD!";
            purchase10b.interactable = false;
        }
        else
        {
            purchase10b.interactable = true;
        }

        //YellowCube
        isYellowCubeSold = PlayerPrefs.GetInt("IsYellowCubeSold");
        if (coinCount >= yellowCubeValue && isYellowCubeSold == 0)
        {
            purchase11.gameObject.SetActive(true);
            buyYellowCube.interactable = true;
            yellowCubeText.text = (yellowCubeValue.ToString());
        }
        else
        {
            purchase11.gameObject.SetActive(false);
            buyYellowCube.interactable = false;
            yellowCubeText.text = (yellowCubeValue.ToString());
        }

        if (isYellowCubeSold == 1)
        {
            buyYellowCube.interactable = false;
            yellowCubeText.text = "SOLD!";
            purchase11b.interactable = false;
        }
        else
        {
            purchase11b.interactable = true;
        }

        //WhiteCube
        isWhiteCubeSold = PlayerPrefs.GetInt("IsWhiteCubeSold");
        if (coinCount >= whiteCubeValue && isWhiteCubeSold == 0)
        {
            purchase12.gameObject.SetActive(true);
            buyWhiteCube.interactable = true;
            whiteCubeText.text = (whiteCubeValue.ToString());
        }
        else
        {
            purchase12.gameObject.SetActive(false);
            buyWhiteCube.interactable = false;
            whiteCubeText.text = (whiteCubeValue.ToString());
        }

        if (isWhiteCubeSold == 1)
        {
            buyWhiteCube.interactable = false;
            whiteCubeText.text = "SOLD!";
            purchase12b.interactable = false;
        }
        else
        {
            purchase12b.interactable = true;
        }

        //BlackCube
        isBlackCubeSold = PlayerPrefs.GetInt("IsBlackCubeSold");
        if (coinCount >= blackCubeValue && isBlackCubeSold == 0)
        {
            purchase13.gameObject.SetActive(true);
            buyBlackCube.interactable = true;
            blackCubeText.text = (blackCubeValue.ToString());
        }
        else
        {
            purchase13.gameObject.SetActive(false);
            buyBlackCube.interactable = false;
            blackCubeText.text = (blackCubeValue.ToString());
        }

        if (isBlackCubeSold == 1)
        {
            buyBlackCube.interactable = false;
            blackCubeText.text = "SOLD!";
            purchase13b.interactable = false;
        }
        else
        {
            purchase13b.interactable = true;
        }

        //TigerSkin
        isTigerSkinSold = PlayerPrefs.GetInt("IsTigerSkinSold");
        if (coinCount >= tigerSkinValue && isTigerSkinSold == 0)
        {
            purchase14.gameObject.SetActive(true);
            buyTigerSkin.interactable = true;
            tigerSkinText.text = (tigerSkinValue.ToString());
        }
        else
        {
            purchase14.gameObject.SetActive(false);
            buyTigerSkin.interactable = false;
            tigerSkinText.text = (tigerSkinValue.ToString());
        }

        if (isTigerSkinSold == 1)
        {
            buyTigerSkin.interactable = false;
            tigerSkinText.text = "SOLD!";
            purchase14b.interactable = false;
        }
        else
        {
            purchase14b.interactable = true;
        }

        //CamoSkin
        isCamoSkinSold = PlayerPrefs.GetInt("IsCamoSkinSold");
        if (coinCount >= camoSkinValue && isCamoSkinSold == 0)
        {
            purchase15.gameObject.SetActive(true);
            buyCamoSkin.interactable = true;
            camoSkinText.text = (camoSkinValue.ToString());
        }
        else
        {
            purchase15.gameObject.SetActive(false);
            buyCamoSkin.interactable = false;
            camoSkinText.text = (camoSkinValue.ToString());
        }

        if (isCamoSkinSold == 1)
        {
            buyCamoSkin.interactable = false;
            camoSkinText.text = "SOLD!";
            purchase15b.interactable = false;
        }
        else
        {
            purchase15b.interactable = true;
        }

        //ArticSkin
        isArticSkinSold = PlayerPrefs.GetInt("IsArticSkinSold");
        if (coinCount >= articSkinValue && isArticSkinSold == 0)
        {
            purchase16.gameObject.SetActive(true);
            buyArticSkin.interactable = true;
            articSkinText.text = (articSkinValue.ToString());
        }
        else
        {
            purchase16.gameObject.SetActive(false);
            buyArticSkin.interactable = false;
            articSkinText.text = (articSkinValue.ToString());
        }

        if (isArticSkinSold == 1)
        {
            buyArticSkin.interactable = false;
            articSkinText.text = "SOLD!";
            purchase16b.interactable = false;
        }
        else
        {
            purchase16b.interactable = true;
        }

        //DesertSkin
        isDesertSkinSold = PlayerPrefs.GetInt("IsDesertSkinSold");
        if (coinCount >= desertSkinValue && isDesertSkinSold == 0)
        {
            purchase17.gameObject.SetActive(true);
            buyDesertSkin.interactable = true;
            desertSkinText.text = (desertSkinValue.ToString());
        }
        else
        {
            purchase17.gameObject.SetActive(false);
            buyDesertSkin.interactable = false;
            desertSkinText.text = (desertSkinValue.ToString());
        }

        if (isDesertSkinSold == 1)
        {
            buyDesertSkin.interactable = false;
            desertSkinText.text = "SOLD!";
            purchase17b.interactable = false;
        }
        else
        {
            purchase17b.interactable = true;
        }

        //CrateSkin
        isCrateSkinSold = PlayerPrefs.GetInt("IsCrateSkinSold");
        if (coinCount >= crateSkinValue && isCrateSkinSold == 0)
        {
            purchase18.gameObject.SetActive(true);
            buyCrateSkin.interactable = true;
            crateSkinText.text = (crateSkinValue.ToString());
        }
        else
        {
            purchase18.gameObject.SetActive(false);
            buyCrateSkin.interactable = false;
            crateSkinText.text = (crateSkinValue.ToString());
        }

        if (isCrateSkinSold == 1)
        {
            buyCrateSkin.interactable = false;
            crateSkinText.text = "SOLD!";
            purchase18b.interactable = false;
        }
        else
        {
            purchase18b.interactable = true;
        }

        //FireSkin
        isFireSkinSold = PlayerPrefs.GetInt("IsFireSkinSold");
        if (coinCount >= fireSkinValue && isFireSkinSold == 0)
        {
            purchase19.gameObject.SetActive(true);
            buyFireSkin.interactable = true;
            fireSkinText.text = (fireSkinValue.ToString());
        }
        else
        {
            purchase19.gameObject.SetActive(false);
            buyFireSkin.interactable = false;
            fireSkinText.text = (fireSkinValue.ToString());
        }

        if (isFireSkinSold == 1)
        {
            buyFireSkin.interactable = false;
            fireSkinText.text = "SOLD!";
            purchase19b.interactable = false;
        }
        else
        {
            purchase19b.interactable = true;
        }

        //City BG
        isCitySold = PlayerPrefs.GetInt("IsCitySold");
        if (coinCount >= cityValue && isCitySold == 0)
        {
            purchase20.gameObject.SetActive(true);
            buyCity.interactable = true;
            cityText.text = (cityValue.ToString());
        }
        else
        {
            purchase20.gameObject.SetActive(false);
            buyCity.interactable = false;
            cityText.text = (cityValue.ToString());
        }

        if (isCitySold == 1)
        {
            buyCity.interactable = false;
            cityText.text = "SOLD!";
            purchase20b.interactable = false;
        }
        else
        {
            purchase20b.interactable = true;
        }

        //Lava BG
        isLavaSold = PlayerPrefs.GetInt("IsLavaSold");
        if (coinCount >= lavaValue && isLavaSold == 0)
        {
            purchase21.gameObject.SetActive(true);
            buyLava.interactable = true;
            lavaText.text = (lavaValue.ToString());
        }
        else
        {
            purchase21.gameObject.SetActive(false);
            buyLava.interactable = false;
            lavaText.text = (lavaValue.ToString());
        }

        if (isLavaSold == 1)
        {
            buyLava.interactable = false;
            lavaText.text = "SOLD!";
            purchase21b.interactable = false;
        }
        else
        {
            purchase21b.interactable = true;
        }

        //Forest BG
        isForestSold = PlayerPrefs.GetInt("IsForestSold");
        if (coinCount >= forestValue && isForestSold == 0)
        {
            purchase22.gameObject.SetActive(true);
            buyForest.interactable = true;
            forestText.text = (forestValue.ToString());
        }
        else
        {
            purchase22.gameObject.SetActive(false);
            buyForest.interactable = false;
            forestText.text = (forestValue.ToString());
        }

        if (isForestSold == 1)
        {
            buyForest.interactable = false;
            forestText.text = "SOLD!";
            purchase22b.interactable = false;
        }
        else
        {
            purchase22b.interactable = true;
        }

        //Future BG
        isFutureSold = PlayerPrefs.GetInt("IsFutureSold");
        if (coinCount >= futureValue && isFutureSold == 0)
        {
            purchase23.gameObject.SetActive(true);
            buyFuture.interactable = true;
            futureText.text = (futureValue.ToString());
        }
        else
        {
            purchase23.gameObject.SetActive(false);
            buyFuture.interactable = false;
            futureText.text = (futureValue.ToString());
        }

        if (isFutureSold == 1)
        {
            buyFuture.interactable = false;
            futureText.text = "SOLD!";
            purchase23b.interactable = false;
        } 
        else
        {
            purchase23b.interactable = true;
        }

        coinCount = PlayerPrefs.GetInt("CoinCount");

    }

    public void PurchaseLaser()
    {
        theScoreManager.coinCount -= laserValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsLaserSold", 1);
    }

    public void PurchaseShrink()
    {
        theScoreManager.coinCount -= shrinkValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsShrinkSold", 1);
    }

    public void PurchaseSlowMo()
    {
        theScoreManager.coinCount -= slowMoValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsSlowMoSold", 1);
    }

    public void PurchaseShield()
    {
        theScoreManager.coinCount -= shieldValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsShieldSold", 1);
    }

    public void PurchaseRedCube()
    {
        theScoreManager.coinCount -= redCubeValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsRedCubeSold", 1);
    }

    public void PurchaseBlueCube()
    {
        theScoreManager.coinCount -= blueCubeValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsBlueCubeSold", 1);
    }

    public void PurchaseGreenCube()
    {
        theScoreManager.coinCount -= greenCubeValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsGreenCubeSold", 1);
    }

    public void PurchasePinkCube()
    {
        theScoreManager.coinCount -= pinkCubeValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsPinkCubeSold", 1);
    }

    public void PurchaseOrangeCube()
    {
        theScoreManager.coinCount -= orangeCubeValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsOrangeCubeSold", 1);
    }

    public void PurchasePurpleCube()
    {
        theScoreManager.coinCount -= purpleCubeValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsPurpleCubeSold", 1);
    }

    public void PurchaseYellowCube()
    {
        theScoreManager.coinCount -= yellowCubeValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsYellowCubeSold", 1);
    }

    public void PurchaseWhiteCube()
    {
        theScoreManager.coinCount -= whiteCubeValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsWhiteCubeSold", 1);
    }

    public void PurchaseBlackCube()
    {
        theScoreManager.coinCount -= blackCubeValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsBlackCubeSold", 1);
    }

    public void PurchaseTigerSkin()
    {
        theScoreManager.coinCount -= tigerSkinValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsTigerSkinSold", 1);
    }

    public void PurchaseCamoSkin()
    {
        theScoreManager.coinCount -= camoSkinValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsCamoSkinSold", 1);
    }

    public void PurchaseArticSkin()
    {
        theScoreManager.coinCount -= articSkinValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsArticSkinSold", 1);
    }

    public void PurchaseDesertSkin()
    {
        theScoreManager.coinCount -= desertSkinValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsDesertSkinSold", 1);
    }

    public void PurchaseCrateSkin()
    {
        theScoreManager.coinCount -= crateSkinValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsCrateSkinSold", 1);
    }

    public void PurchaseFireSkin()
    {
        theScoreManager.coinCount -= fireSkinValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsFireSkinSold", 1);
    }

    public void PurchaseCityBG()
    {
        theScoreManager.coinCount -= cityValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsCitySold", 1);
    }

    public void PurchaseLavaBG()
    {
        theScoreManager.coinCount -= lavaValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsLavaSold", 1);
    }

    public void PurchaseForestBG()
    {
        theScoreManager.coinCount -= forestValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsForestSold", 1);
    }

    public void PurchaseFutureBG()
    {
        theScoreManager.coinCount -= futureValue;
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        PlayerPrefs.SetInt("IsFutureSold", 1);
    }

    public void ExitShop()
    {
        PlayerPrefs.SetInt("CoinCount", theScoreManager.coinCount);
        SceneManager.LoadScene("Menu");
    }

    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        coinCount = 0;
    }
}
