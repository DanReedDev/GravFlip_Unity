using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PowerUpManager : MonoBehaviour
{

    int isLaserActive;
    int isLaserSold;
    int isShrinkActive;
    int isShrinkSold;
    int isSlowMoActive;
    int isSlowMoSold;
    int isShieldActive;
    int isShieldSold;

    int isRedCubeActive;
    int isRedCubeSold;
    int isBlueCubeActive;
    int isBlueCubeSold;
    int isGreenCubeActive;
    int isGreenCubeSold;
    int isPinkCubeActive;
    int isPinkCubeSold;
    int isOrangeCubeActive;
    int isOrangeCubeSold;
    int isPurpleCubeActive;
    int isPurpleCubeSold;
    int isYellowCubeActive;
    int isYellowCubeSold;
    int isWhiteCubeActive;
    int isWhiteCubeSold;
    int isBlackCubeActive;
    int isBlackCubeSold;

    int isGraphicSkinActive;

    int isTigerSkinSold;
    int isCamoSkinSold;
    int isArticSkinSold;
    int isDesertSkinSold;
    int isCrateSkinSold;

    int isFireSkinActive;
    int isFireSkinSold;

    int activeBackground;

    int isCitySold;
    int isLavaSold;
    int isForestSold;
    int isFutureSold;

    public Button laserOnOff;
    public Button shrinkOnOff;
    public Button slowMoOnOff;
    public Button shieldOnOff;

    public Button redCubeOnOff;
    public Button blueCubeOnOff;
    public Button greenCubeOnOff;
    public Button pinkCubeOnOff;
    public Button orangeCubeOnOff;
    public Button purpleCubeOnOff;
    public Button yellowCubeOnOff;
    public Button whiteCubeOnOff;
    public Button blackCubeOnOff;

    public Button tigerSkinOnOff;
    public Button camoSkinOnOff;
    public Button articSkinOnOff;
    public Button desertSkinOnOff;
    public Button crateSkinOnOff;

    public Button fireSkinOnOff;

    public Button cityOnOff;
    public Button lavaOnOff;
    public Button forestOnOff;
    public Button futureOnOff;

    public Text laserActivity;
    public Text shrinkActivity;
    public Text slowMoActivity;
    public Text shieldActivity;

    public Text redCubeActivity;
    public Text blueCubeActivity;
    public Text greenCubeActivity;
    public Text pinkCubeActivity;
    public Text orangeCubeActivity;
    public Text purpleCubeActivity;
    public Text yellowCubeActivity;
    public Text whiteCubeActivity;
    public Text blackCubeActivity;

    public Text tigerSkinActivity;
    public Text camoSkinActivity;
    public Text articSkinActivity;
    public Text desertSkinActivity;
    public Text crateSkinActivity;

    public Text fireSkinActivity;

    public Text cityActivity;
    public Text lavaActivity;
    public Text forestActivity;
    public Text futureActivity;

    void Start()
    {

    }

    public void Awake()
    {
        //Application.targetFrameRate = 60;
    }

    void Update()
    {
        isLaserActive = PlayerPrefs.GetInt("IsLaserActive");
        isLaserSold = PlayerPrefs.GetInt("IsLaserSold");
        isShrinkActive = PlayerPrefs.GetInt("IsShrinkActive");
        isShrinkSold = PlayerPrefs.GetInt("IsShrinkSold");
        isSlowMoActive = PlayerPrefs.GetInt("IsSlowMoActive");
        isSlowMoSold = PlayerPrefs.GetInt("IsSlowMoSold");
        isShieldActive = PlayerPrefs.GetInt("IsShieldActive");
        isShieldSold = PlayerPrefs.GetInt("IsShieldSold");

        isRedCubeSold = PlayerPrefs.GetInt("IsRedCubeSold");
        isRedCubeActive = PlayerPrefs.GetInt("IsRedCubeActive");
        isBlueCubeSold = PlayerPrefs.GetInt("IsBlueCubeSold");
        isBlueCubeActive = PlayerPrefs.GetInt("IsBlueCubeActive");
        isGreenCubeSold = PlayerPrefs.GetInt("IsGreenCubeSold");
        isGreenCubeActive = PlayerPrefs.GetInt("IsGreenCubeActive");
        isPinkCubeSold = PlayerPrefs.GetInt("IsPinkCubeSold");
        isPinkCubeActive = PlayerPrefs.GetInt("IsPinkCubeActive");
        isOrangeCubeSold = PlayerPrefs.GetInt("IsOrangeCubeSold");
        isOrangeCubeActive = PlayerPrefs.GetInt("IsOrangeCubeActive");
        isPurpleCubeSold = PlayerPrefs.GetInt("IsPurpleCubeSold");
        isPurpleCubeActive = PlayerPrefs.GetInt("IsPurpleCubeActive");
        isYellowCubeSold = PlayerPrefs.GetInt("IsYellowCubeSold");
        isYellowCubeActive = PlayerPrefs.GetInt("IsYellowCubeActive");
        isWhiteCubeSold = PlayerPrefs.GetInt("IsWhiteCubeSold");
        isWhiteCubeActive = PlayerPrefs.GetInt("IsWhiteCubeActive");
        isBlackCubeSold = PlayerPrefs.GetInt("IsBlackCubeSold");
        isBlackCubeActive = PlayerPrefs.GetInt("IsBlackCubeActive");

        isGraphicSkinActive = PlayerPrefs.GetInt("IsGraphicSkinActive");

        isTigerSkinSold = PlayerPrefs.GetInt("IsTigerSkinSold");
        isCamoSkinSold = PlayerPrefs.GetInt("IsCamoSkinSold");
        isArticSkinSold = PlayerPrefs.GetInt("IsArticSkinSold");
        isDesertSkinSold = PlayerPrefs.GetInt("IsDesertSkinSold");
        isCrateSkinSold = PlayerPrefs.GetInt("IsCrateSkinSold");

        isFireSkinActive = PlayerPrefs.GetInt("IsFireSkinActive");
        isFireSkinSold = PlayerPrefs.GetInt("IsFireSkinSold");

        activeBackground = PlayerPrefs.GetInt("ActiveBackground");

        isCitySold = PlayerPrefs.GetInt("IsCitySold");
        isLavaSold = PlayerPrefs.GetInt("IsLavaSold");
        isForestSold = PlayerPrefs.GetInt("IsForestSold");
        isFutureSold = PlayerPrefs.GetInt("IsFutureSold");

        //Laser
        if (isLaserSold == 0)
        {
            laserOnOff.interactable = false;
            laserOnOff.gameObject.SetActive(false);
        } else
        {
            laserOnOff.interactable = true;
            laserOnOff.gameObject.SetActive(true);
        }

        if (isLaserActive == 0)
        {
            laserActivity.text = "Off";
        } else
        {
            laserActivity.text = "On";
        }

        //Shrink
        if (isShrinkSold == 0)
        {
            shrinkOnOff.interactable = false;
            shrinkOnOff.gameObject.SetActive(false);
        }
        else
        {
            shrinkOnOff.interactable = true;
            shrinkOnOff.gameObject.SetActive(true);
        }

        if (isShrinkActive == 0)
        {
            shrinkActivity.text = "Off";
        }
        else
        {
            shrinkActivity.text = "On";
        }

        //SlowMo
        if (isSlowMoSold == 0)
        {
            slowMoOnOff.interactable = false;
            slowMoOnOff.gameObject.SetActive(false);
        }
        else
        {
            slowMoOnOff.interactable = true;
            slowMoOnOff.gameObject.SetActive(true);
        }

        if (isSlowMoActive == 0)
        {
            slowMoActivity.text = "Off";
        }
        else
        {
            slowMoActivity.text = "On";
        }

        //Shield
        if (isShieldSold == 0)
        {
            shieldOnOff.interactable = false;
            shieldOnOff.gameObject.SetActive(false);
        }
        else
        {
            shieldOnOff.interactable = true;
            shieldOnOff.gameObject.SetActive(true);
        }

        if (isShieldActive == 0)
        {
            shieldActivity.text = "Off";
        }
        else
        {
            shieldActivity.text = "On";
        }

        //RedCube
        if (isRedCubeSold == 0)
        {
            redCubeOnOff.interactable = false;
            redCubeOnOff.gameObject.SetActive(false);
        } else
        {
            redCubeOnOff.interactable = true;
            redCubeOnOff.gameObject.SetActive(true);
        }

        if (isRedCubeActive == 0)
        {
            redCubeActivity.text = "Off";
        } else
        {
            redCubeActivity.text = "On";
        }

        //GreenCube
        if (isGreenCubeSold == 0)
        {
            greenCubeOnOff.interactable = false;
            greenCubeOnOff.gameObject.SetActive(false);
        }
        else
        {
            greenCubeOnOff.interactable = true;
            greenCubeOnOff.gameObject.SetActive(true);
        }

        if (isGreenCubeActive == 0)
        {
            greenCubeActivity.text = "Off";
        }
        else
        {
            greenCubeActivity.text = "On";
        }

        //BlueCube
        if (isBlueCubeSold == 0)
        {
            blueCubeOnOff.interactable = false;
            blueCubeOnOff.gameObject.SetActive(false);
        }
        else
        {
            blueCubeOnOff.interactable = true;
            blueCubeOnOff.gameObject.SetActive(true);
        }

        if (isBlueCubeActive == 0)
        {
            blueCubeActivity.text = "Off";
        }
        else
        {
            blueCubeActivity.text = "On";
        }

        //PinkCube
        if (isPinkCubeSold == 0)
        {
            pinkCubeOnOff.interactable = false;
            pinkCubeOnOff.gameObject.SetActive(false);
        }
        else
        {
            pinkCubeOnOff.interactable = true;
            pinkCubeOnOff.gameObject.SetActive(true);
        }

        if (isPinkCubeActive == 0)
        {
            pinkCubeActivity.text = "Off";
        }
        else
        {
            pinkCubeActivity.text = "On";
        }

        //OrangeCube
        if (isOrangeCubeSold == 0)
        {
            orangeCubeOnOff.interactable = false;
            orangeCubeOnOff.gameObject.SetActive(false);
        }
        else
        {
            orangeCubeOnOff.interactable = true;
            orangeCubeOnOff.gameObject.SetActive(true);
        }

        if (isOrangeCubeActive == 0)
        {
            orangeCubeActivity.text = "Off";
        }
        else
        {
            orangeCubeActivity.text = "On";
        }

        //PurpleCube
        if (isPurpleCubeSold == 0)
        {
            purpleCubeOnOff.interactable = false;
            purpleCubeOnOff.gameObject.SetActive(false);
        }
        else
        {
            purpleCubeOnOff.interactable = true;
            purpleCubeOnOff.gameObject.SetActive(true);
        }

        if (isPurpleCubeActive == 0)
        {
            purpleCubeActivity.text = "Off";
        }
        else
        {
            purpleCubeActivity.text = "On";
        }

        //YellowCube
        if (isYellowCubeSold == 0)
        {
            yellowCubeOnOff.interactable = false;
            yellowCubeOnOff.gameObject.SetActive(false);
        }
        else
        {
            yellowCubeOnOff.interactable = true;
            yellowCubeOnOff.gameObject.SetActive(true);
        }

        if (isYellowCubeActive == 0)
        {
            yellowCubeActivity.text = "Off";
        }
        else
        {
            yellowCubeActivity.text = "On";
        }

        //WhiteCube
        if (isWhiteCubeSold == 0)
        {
            whiteCubeOnOff.interactable = false;
            whiteCubeOnOff.gameObject.SetActive(false);
        }
        else
        {
            whiteCubeOnOff.interactable = true;
            whiteCubeOnOff.gameObject.SetActive(true);
        }

        if (isWhiteCubeActive == 0)
        {
            whiteCubeActivity.text = "Off";
        }
        else
        {
            whiteCubeActivity.text = "On";
        }

        //BlackCube
        if (isBlackCubeSold == 0)
        {
            blackCubeOnOff.interactable = false;
            blackCubeOnOff.gameObject.SetActive(false);
        }
        else
        {
            blackCubeOnOff.interactable = true;
            blackCubeOnOff.gameObject.SetActive(true);
        }

        if (isBlackCubeActive == 0)
        {
            blackCubeActivity.text = "Off";
        }
        else
        {
            blackCubeActivity.text = "On";
        }

        //TigerSkin
        if (isTigerSkinSold == 0)
        {
            tigerSkinOnOff.interactable = false;
            tigerSkinOnOff.gameObject.SetActive(false);
        }
        else
        {
            tigerSkinOnOff.interactable = true;
            tigerSkinOnOff.gameObject.SetActive(true);
        }

        //CamoSkin
        if (isCamoSkinSold == 0)
        {
            camoSkinOnOff.interactable = false;
            camoSkinOnOff.gameObject.SetActive(false);
        }
        else
        {
            camoSkinOnOff.interactable = true;
            camoSkinOnOff.gameObject.SetActive(true);
        }

        //ArticSkin
        if (isArticSkinSold == 0)
        {
            articSkinOnOff.interactable = false;
            articSkinOnOff.gameObject.SetActive(false);
        }
        else
        {
            articSkinOnOff.interactable = true;
            articSkinOnOff.gameObject.SetActive(true);
        }

        //DesertSkin
        if (isDesertSkinSold == 0)
        {
            desertSkinOnOff.interactable = false;
            desertSkinOnOff.gameObject.SetActive(false);
        }
        else
        {
            desertSkinOnOff.interactable = true;
            desertSkinOnOff.gameObject.SetActive(true);
        }

        //CrateSkin
        if (isCrateSkinSold == 0)
        {
            crateSkinOnOff.interactable = false;
            crateSkinOnOff.gameObject.SetActive(false);
        }
        else
        {
            crateSkinOnOff.interactable = true;
            crateSkinOnOff.gameObject.SetActive(true);
        }

        //GraghicSkinLogic
        if (isGraphicSkinActive == 0)
        {
            tigerSkinActivity.text = "Off";
            camoSkinActivity.text = "Off";
            articSkinActivity.text = "Off";
            desertSkinActivity.text = "Off";
            crateSkinActivity.text = "Off";
        }
        else if (isGraphicSkinActive == 1)
        {
            tigerSkinActivity.text = "On";
            camoSkinActivity.text = "Off";
            articSkinActivity.text = "Off";
            desertSkinActivity.text = "Off";
            crateSkinActivity.text = "Off";
        }
        else if (isGraphicSkinActive == 2)
        {
            camoSkinActivity.text = "On";
            tigerSkinActivity.text = "Off";
            articSkinActivity.text = "Off";
            desertSkinActivity.text = "Off";
            crateSkinActivity.text = "Off";
        }
        else if (isGraphicSkinActive == 3)
        {
            articSkinActivity.text = "On";
            tigerSkinActivity.text = "Off";
            camoSkinActivity.text = "Off";
            desertSkinActivity.text = "Off";
            crateSkinActivity.text = "Off";
        }
        else if (isGraphicSkinActive == 4)
        {
            desertSkinActivity.text = "On";
            tigerSkinActivity.text = "Off";
            camoSkinActivity.text = "Off";
            articSkinActivity.text = "Off";
            crateSkinActivity.text = "Off";
        }
        else if (isGraphicSkinActive == 5)
        {
            crateSkinActivity.text = "On";
            tigerSkinActivity.text = "Off";
            camoSkinActivity.text = "Off";
            articSkinActivity.text = "Off";
            desertSkinActivity.text = "Off";
        }
        else 
        {
            tigerSkinActivity.text = "Off";
            camoSkinActivity.text = "Off";
            articSkinActivity.text = "Off";
            desertSkinActivity.text = "Off";
            crateSkinActivity.text = "Off";
        }

        //FireSkin
        if (isFireSkinSold == 0)
        {
            fireSkinOnOff.interactable = false;
            fireSkinOnOff.gameObject.SetActive(false);
        }
        else
        {
            fireSkinOnOff.interactable = true;
            fireSkinOnOff.gameObject.SetActive(true);
        }

        if (isFireSkinActive == 0)
        {
            fireSkinActivity.text = "Off";
        }
        else
        {
            fireSkinActivity.text = "On";
        }

        //City
        if (isCitySold == 0)
        {
            cityOnOff.interactable = false;
            cityOnOff.gameObject.SetActive(false);
        }
        else
        {
            cityOnOff.interactable = true;
            cityOnOff.gameObject.SetActive(true);
        }

        //Lava
        if (isLavaSold == 0)
        {
            lavaOnOff.interactable = false;
            lavaOnOff.gameObject.SetActive(false);
        }
        else
        {
            lavaOnOff.interactable = true;
            lavaOnOff.gameObject.SetActive(true);
        }

        //Forest
        if (isForestSold == 0)
        {
            forestOnOff.interactable = false;
            forestOnOff.gameObject.SetActive(false);
        }
        else
        {
            forestOnOff.interactable = true;
            forestOnOff.gameObject.SetActive(true);
        }

        //Future
        if (isFutureSold == 0)
        {
            futureOnOff.interactable = false;
            futureOnOff.gameObject.SetActive(false);
        }
        else
        {
            futureOnOff.interactable = true;
            futureOnOff.gameObject.SetActive(true);
        }

        //Background Logic
        if (activeBackground == 0)
        {
            cityActivity.text = "Off";
            lavaActivity.text = "Off";
            forestActivity.text = "Off";
            futureActivity.text = "Off";
        }
        else if (activeBackground == 1)
        {
            cityActivity.text = "On";
            lavaActivity.text = "Off";
            forestActivity.text = "Off";
            futureActivity.text = "Off";
        }
        else if (activeBackground == 2)
        {
            cityActivity.text = "Off";
            lavaActivity.text = "On";
            forestActivity.text = "Off";
            futureActivity.text = "Off";
        }
        else if (activeBackground == 3)
        {
            cityActivity.text = "Off";
            lavaActivity.text = "Off";
            forestActivity.text = "On";
            futureActivity.text = "Off";
        }
        else if (activeBackground == 4)
        {
            cityActivity.text = "Off";
            lavaActivity.text = "Off";
            forestActivity.text = "Off";
            futureActivity.text = "On";
        }
        else
        {
            cityActivity.text = "Off";
            lavaActivity.text = "Off";
            forestActivity.text = "Off";
            futureActivity.text = "Off";
        }

    }

    public void SetLaserActivity()
    {

        if (isLaserActive == 0)
        {
            PlayerPrefs.SetInt("IsLaserActive", 1);
            laserActivity.text = "On";
            PlayerPrefs.SetInt("IsShrinkActive", 0);
            PlayerPrefs.SetInt("IsSlowMoActive", 0);
            PlayerPrefs.SetInt("IsShieldActive", 0);
        } else
        {
            PlayerPrefs.SetInt("IsLaserActive", 0);
            laserActivity.text = "Off";
        }

    }

    public void SetShrinkActivity()
    {

        if (isShrinkActive == 0)
        {
            PlayerPrefs.SetInt("IsShrinkActive", 1);
            shrinkActivity.text = "On";
            PlayerPrefs.SetInt("IsLaserActive", 0);
            PlayerPrefs.SetInt("IsSlowMoActive", 0);
            PlayerPrefs.SetInt("IsShieldActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsShrinkActive", 0);
            shrinkActivity.text = "Off";
        }

    }

    public void SetSlowMoActivity()
    {

        if (isSlowMoActive == 0)
        {
            PlayerPrefs.SetInt("IsSlowMoActive", 1);
            slowMoActivity.text = "On";
            PlayerPrefs.SetInt("IsShrinkActive", 0);
            PlayerPrefs.SetInt("IsLaserActive", 0);
            PlayerPrefs.SetInt("IsShieldActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsSlowMoActive", 0);
            slowMoActivity.text = "Off";
        }

    }

    public void SetShieldActivity()
    {

        if (isShieldActive == 0)
        {
            PlayerPrefs.SetInt("IsShieldActive", 1);
            shieldActivity.text = "On";
            PlayerPrefs.SetInt("IsShrinkActive", 0);
            PlayerPrefs.SetInt("IsSlowMoActive", 0);
            PlayerPrefs.SetInt("IsLaserActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsShieldActive", 0);
            shieldActivity.text = "Off";
        }

    }

    public void SetRedCubeActivity()
    {

        if (isRedCubeActive == 0)
        {
            PlayerPrefs.SetInt("IsRedCubeActive", 1);
            redCubeActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
        } else
        {
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            redCubeActivity.text = "Off";
        }

    }

    public void SetBlueCubeActivity()
    {

        if (isBlueCubeActive == 0)
        {
            PlayerPrefs.SetInt("IsBlueCubeActive", 1);
            blueCubeActivity.text = "On";
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            blueCubeActivity.text = "Off";
        }

    }

    public void SetGreenCubeActivity()
    {
        if (isGreenCubeActive == 0)
        {
            PlayerPrefs.SetInt("IsGreenCubeActive", 1);
            greenCubeActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            greenCubeActivity.text = "Off";
        }
    }

    public void SetPinkCubeActivity()
    {
        if (isPinkCubeActive == 0)
        {
            PlayerPrefs.SetInt("IsPinkCubeActive", 1);
            pinkCubeActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            pinkCubeActivity.text = "Off";
        }
    }

    public void SetOrangeCubeActivity()
    {
        if (isOrangeCubeActive == 0)
        {
            PlayerPrefs.SetInt("IsOrangeCubeActive", 1);
            orangeCubeActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            orangeCubeActivity.text = "Off";
        }
    }

    public void SetPurpleCubeActivity()
    {
        if (isPurpleCubeActive == 0)
        {
            PlayerPrefs.SetInt("IsPurpleCubeActive", 1);
            purpleCubeActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            purpleCubeActivity.text = "Off";
        }
    }

    public void SetYellowCubeActivity()
    {
        if (isYellowCubeActive == 0)
        {
            PlayerPrefs.SetInt("IsYellowCubeActive", 1);
            yellowCubeActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            yellowCubeActivity.text = "Off";
        }
    }

    public void SetWhiteCubeActivity()
    {
        if (isWhiteCubeActive == 0)
        {
            PlayerPrefs.SetInt("IsWhiteCubeActive", 1);
            whiteCubeActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            whiteCubeActivity.text = "Off";
        }
    }

    public void SetBlackCubeActivity()
    {
        if (isBlackCubeActive == 0)
        {
            PlayerPrefs.SetInt("IsBlackCubeActive", 1);
            blackCubeActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
        }
        else
        {
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);
            blackCubeActivity.text = "Off";
        }
    }

    public void SetTigerSkinActivity()
    {
        if (isGraphicSkinActive != 1)
        {
            PlayerPrefs.SetInt("IsGraphicSkinActive", 1);
            tigerSkinActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);

        }
        else
        {
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
            tigerSkinActivity.text = "Off";
        }
    }

    public void SetCamoSkinActivity()
    {
        if (isGraphicSkinActive != 2)
        {
            PlayerPrefs.SetInt("IsGraphicSkinActive", 2);
            camoSkinActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);

        }
        else
        {
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
            camoSkinActivity.text = "Off";
        }
    }

    public void SetArticSkinActivity()
    {
        if (isGraphicSkinActive != 3)
        {
            PlayerPrefs.SetInt("IsGraphicSkinActive", 3);
            articSkinActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);

        }
        else
        {
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
            articSkinActivity.text = "Off";
        }
    }

    public void SetDesertSkinActivity()
    {
        if (isGraphicSkinActive != 4)
        {
            PlayerPrefs.SetInt("IsGraphicSkinActive", 4);
            desertSkinActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);

        }
        else
        {
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
            desertSkinActivity.text = "Off";
        }
    }

    public void SetCrateSkinActivity()
    {
        if (isGraphicSkinActive != 5)
        {
            PlayerPrefs.SetInt("IsGraphicSkinActive", 5);
            crateSkinActivity.text = "On";
            PlayerPrefs.SetInt("IsBlueCubeActive", 0);
            PlayerPrefs.SetInt("IsGreenCubeActive", 0);
            PlayerPrefs.SetInt("IsPinkCubeActive", 0);
            PlayerPrefs.SetInt("IsOrangeCubeActive", 0);
            PlayerPrefs.SetInt("IsPurpleCubeActive", 0);
            PlayerPrefs.SetInt("IsYellowCubeActive", 0);
            PlayerPrefs.SetInt("IsWhiteCubeActive", 0);
            PlayerPrefs.SetInt("IsRedCubeActive", 0);
            PlayerPrefs.SetInt("IsBlackCubeActive", 0);

        }
        else
        {
            PlayerPrefs.SetInt("IsGraphicSkinActive", 0);
            crateSkinActivity.text = "Off";
        }
    }

    public void SetFireSkinActivity()
    {

        if (isFireSkinActive == 0)
        {
            PlayerPrefs.SetInt("IsFireSkinActive", 1);
            fireSkinActivity.text = "On";
        }
        else
        {
            PlayerPrefs.SetInt("IsFireSkinActive", 0);
            fireSkinActivity.text = "Off";
        }

    }

    public void SetCityBgActivity()
    {
        if (activeBackground != 1)
        {
            PlayerPrefs.SetInt("ActiveBackground", 1);
            cityActivity.text = "On";
        }
        else
        {
            PlayerPrefs.SetInt("ActiveBackground", 0);
            cityActivity.text = "Off";
        }
    }

    public void SetLavaBgActivity()
    {
        if (activeBackground != 2)
        {
            PlayerPrefs.SetInt("ActiveBackground", 2);
            lavaActivity.text = "On";
        }
        else
        {
            PlayerPrefs.SetInt("ActiveBackground", 0);
            lavaActivity.text = "Off";
        }
    }

    public void SetForestBgActivity()
    {
        if (activeBackground != 3)
        {
            PlayerPrefs.SetInt("ActiveBackground", 3);
            forestActivity.text = "On";
        }
        else
        {
            PlayerPrefs.SetInt("ActiveBackground", 0);
           forestActivity.text = "Off";
        }
    }

    public void SetFutureBgActivity()
    {
        if (activeBackground != 4)
        {
            PlayerPrefs.SetInt("ActiveBackground", 4);
            futureActivity.text = "Off";
        }
        else
        {
            PlayerPrefs.SetInt("ActiveBackground", 0);
            futureActivity.text = "On";
        }
    }

}
