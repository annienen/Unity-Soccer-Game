﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript2 : MonoBehaviour {

    LevelManager levelManager;
    public Text score;
    public static int score1 = 0;
    public static int score2 = 0;



    // Use this for initialization
    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
         score1 = BallScript2.playerScore1 ;
         score2 = BallScript2.playerScore2 ;

    


        score.text = score2 + "x" + score1;

        if (score1 == 5)
        {
            score.text = "Player 1 Wins This Match";
            levelManager.LoadNewScene("Level3");
        }
        else if (score2 == 5)
        {
            score.text = "Player 2 Wins This Match";
            levelManager.LoadNewScene("Level3");
        }


    }


}