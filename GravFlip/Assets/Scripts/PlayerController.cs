using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movespeed;
    public float jumpforce;
    public float speedMultiplyer;

    public float gravityModifyer = -1;

    public float speedIncreaseMilestone;
    private float speedMilestoneCount;

    public Rigidbody2D myRigidbody;

    public bool Grounded;
    public LayerMask whatIsGround;

    private Collider2D myCollider;

    public float cubeSize = 0.2f;
    public int cubesInRow = 5;

    float cubesPivotDistance;
    Vector3 cubesPivot;

    public float explosionForce = 50f;
    public float explosionRadius = 4f;
    public float explosionUpward = 0.4f;

    AudioSource audioSource;
    Animator myAnimator;

    int difficutly;

    //Store Content
    //PowerUps
    int isNinjaStepActive;

    //Skins
    int isBlueActive;
    int isRedActive;
    int isGreenActive;
    int isPinkActive;
    int isOrangeActive;
    int isPurpleActive;
    int isYellowActive;
    int isWhiteActive;
    int isBlackActive;

    public Material[] material;
    Renderer rend;

    //FX Skins
    int isFireSkinActive;

    //Graphic Skins
    int isGraphicSkinActive;

    int activeBackground;

    //Skins
    public GameObject fireSkin;

    public GameObject cityBg;
    public GameObject lavaBg;
    public GameObject forestBg;
    public GameObject futureBg;
    public GameObject hillsBg;

    void Start()
    {

        Application.targetFrameRate = 300;

        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        myAnimator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

        gameObject.SetActive(true);

        //POWERUPS
        isNinjaStepActive = PlayerPrefs.GetInt("IsNinjaStepActive");
        if (isNinjaStepActive == 1)
        {
            GetComponent<Rigidbody2D>().gravityScale = 80;
        }

        GetComponent<Renderer>().material.color = new Color32(55, 60, 70, 1);

        //COLOURS
        isBlueActive = PlayerPrefs.GetInt("IsBlueCubeActive"); 
        if (isBlueActive == 1)
        {
            GetComponent<Renderer>().material.color = new Color32(30, 144, 225, 1);
        }

        isRedActive = PlayerPrefs.GetInt("IsRedCubeActive");
        if (isRedActive == 1)
        {
            GetComponent<Renderer>().material.color = new Color32(128, 0, 0, 1);
        }

        isGreenActive = PlayerPrefs.GetInt("IsGreenCubeActive");
        if (isGreenActive == 1)
        {
            GetComponent<Renderer>().material.color = new Color32(0,97,80,1);
        }

        isPinkActive = PlayerPrefs.GetInt("IsPinkCubeActive");
        if (isPinkActive == 1)
        {
            GetComponent<Renderer>().material.color = new Color32(255, 105, 180, 1);
        }

        isOrangeActive = PlayerPrefs.GetInt("IsOrangeCubeActive");
        if (isOrangeActive == 1)
        {
            GetComponent<Renderer>().material.color = new Color32(255, 69, 0, 1);
        }

        isPurpleActive = PlayerPrefs.GetInt("IsPurpleCubeActive");
        if (isPurpleActive == 1)
        {
            GetComponent<Renderer>().material.color = new Color32(139, 0, 139, 1);
        }

        isYellowActive = PlayerPrefs.GetInt("IsYellowCubeActive");
        if (isYellowActive == 1)
        {
            GetComponent<Renderer>().material.color = new Color32(255, 255, 0, 1);
        }

        isWhiteActive = PlayerPrefs.GetInt("IsWhiteCubeActive");
        if (isWhiteActive == 1)
        {
            GetComponent<Renderer>().material.color = new Color32(245, 245, 245, 1);
        }

        isBlackActive = PlayerPrefs.GetInt("IsBlackCubeActive");
        if (isBlackActive == 1)
        {
            GetComponent<Renderer>().material.color = new Color32(0, 0, 0, 1);
        }

        //FX SKINS
        isFireSkinActive = PlayerPrefs.GetInt("IsFireSkinActive");
        if (isFireSkinActive == 1)
        {
            fireSkin.gameObject.SetActive(true);
        }

        //GraphicSkins
        isGraphicSkinActive = PlayerPrefs.GetInt("IsGraphicSkinActive");
        if (isGraphicSkinActive > 0)
        {
            rend.sharedMaterial = material[isGraphicSkinActive];
        }

        //Explosion
        cubesPivotDistance = cubeSize * cubesInRow / 2;
        cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);

        difficutly = PlayerPrefs.GetInt("Difficutly");
        if (difficutly == 0)
        {
            movespeed = 10;
        }
        else if (difficutly == 1)
        {
            movespeed = 12;
        }
        else
        {
            movespeed = 16;
        }

    }   


    void Update()
    {

        Grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        if(transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIncreaseMilestone;

            movespeed = movespeed * speedMultiplyer;
        }

        myRigidbody.velocity = new Vector2(movespeed, myRigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (Grounded)
                {
                // JUMPCODE
                //myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpforce);

                //GravityFlip
                myRigidbody.gravityScale *= gravityModifyer;
                //myRenderer.flipY = true;

                }
        }

        //Background
        activeBackground = PlayerPrefs.GetInt("ActiveBackground");
        if (activeBackground == 1)
        {
            cityBg.gameObject.SetActive(true);
            lavaBg.gameObject.SetActive(false);
            forestBg.gameObject.SetActive(false);
            futureBg.gameObject.SetActive(false);
            hillsBg.gameObject.SetActive(false);
        }
        else if (activeBackground == 2)
        {
            cityBg.gameObject.SetActive(false);
            lavaBg.gameObject.SetActive(true);
            forestBg.gameObject.SetActive(false);
            futureBg.gameObject.SetActive(false);
            hillsBg.gameObject.SetActive(false);
        }
        else if (activeBackground == 3)
        {
            cityBg.gameObject.SetActive(false);
            lavaBg.gameObject.SetActive(false);
            forestBg.gameObject.SetActive(true);
            futureBg.gameObject.SetActive(false);
            hillsBg.gameObject.SetActive(false);
        }
        else if (activeBackground == 4)
        {
            cityBg.gameObject.SetActive(false);
            lavaBg.gameObject.SetActive(false);
            forestBg.gameObject.SetActive(false);
            futureBg.gameObject.SetActive(true);
            hillsBg.gameObject.SetActive(false);
        }
        else
        {
            cityBg.gameObject.SetActive(false);
            lavaBg.gameObject.SetActive(false);
            forestBg.gameObject.SetActive(false);
            futureBg.gameObject.SetActive(false);
            hillsBg.gameObject.SetActive(true);
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Coins"))
        {
            audioSource.Play();
            Destroy(other.gameObject);
        }

    }

    public void PlayerDeath()
    {
        gameObject.SetActive(false);
        Explode();
        speedMultiplyer = 0;
        movespeed = 0;
    }

    public void Explode()
    {

        for (int x = 0; x < cubesInRow; x++)
        {
            for (int y = 0; y < cubesInRow; y++)
            {
                for (int z = 0; z < cubesInRow; z++)
                {
                    CreatePiece(x, y, x);
                }
            }
        }

        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, explosionUpward);
            }
        }

    }

    void CreatePiece(int x, int y, int z)
    {
        GameObject Piece;
        Piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

        Piece.transform.position = transform.position + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z) - cubesPivot;
        Piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);

        Piece.AddComponent<Rigidbody>();
        Piece.GetComponent<Rigidbody>().mass = cubeSize;
    }

}
