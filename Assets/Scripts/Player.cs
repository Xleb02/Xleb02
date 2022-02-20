using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour
{
    void Start()
    {
        score = 0;
        activeClick = 1;
    }

    public void OnClick()
    {

        score += activeClick;
    }



    public Text scoreText;
    public Text activeclickText;
    public int score
    {
        get
        {
            return Int32.Parse(scoreText.text);
        }
        set
        {
            if (score == value)
                return;
            scoreText.text = value.ToString();
        }
    }

    public int activeClick
    {

        get
        {
            return Int32.Parse(activeclickText.text);
        }
        set
        {
            if (activeClick == value)
                return;
            activeclickText.text = value.ToString();

        }
    }
    public int pasiveClick;

    public void BuyActivityClick()
    {
        if (score < 30)
            return;

        score -= 30;
        activeClick += 1;
    }
}


   






















