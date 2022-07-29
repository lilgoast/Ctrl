using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;
using TMPro;

public class Scorer : MonoBehaviour
{
    [SerializeField] int scorePerSecond = 30;
    //Less then 7 and bigger then 0
    [SerializeField] int minimalHitAmount = 0;
    //public string textValue;
    //public Text textElement;
    public TMP_Text scoreText;
    public TMP_Text hitCountText;


    int hits = 0;
    float score = 0;
    int mistakeValue = 0;
    int hitAmount;

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "7Hit")
        {
            hits++;
            hitCountText.text = $"{hits} hits";
        }

        if(other.gameObject.tag == "Coin") 
        {
            scorePerSecond += 5;
        }

        hitAmount = Int32.Parse(other.gameObject.tag.Remove(other.gameObject.tag.Length - 3));

        if(hitAmount > minimalHitAmount)
        {
            scorePerSecond -= hitAmount - minimalHitAmount;
            //mistakeValue += hitAmount - minimalHitAmount;
        }
    }

    void Update()
    {
        score += (scorePerSecond - mistakeValue) * Time.deltaTime;
        
        if(score < 0)
        {
            scoreText.text = "You lose!";
            Application.Quit();
        }
        else
        {
            scoreText.text = $"Your score: {Math.Round(score)} | {scorePerSecond} pps";
        }
    }
}
