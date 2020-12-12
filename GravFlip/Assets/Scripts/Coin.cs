using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Coin : MonoBehaviour
{

    public int coinValue;
    int chance;

    void Update()
    {
        chance = Random.Range(1, 100);
        if(chance < 61)
        {
            coinValue = 5;
        }
        else if (chance >= 61 && chance < 95)
        {
            coinValue = 15;
        }
        else if (chance >= 95)
        {
            coinValue = 30;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Shield"))
        {
            ScoreManager.instance.ChangeCoinCount(coinValue);
            ScoreManager.instance.ChangeCurrentCoinCount(coinValue);
        }

    }

 }
