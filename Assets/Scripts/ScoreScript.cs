﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {


    LevelManager levelManager;
    public Text score;

    public static int score1 = 0;
    public static int score2 = 0;


    // Use this for initialization
    void Start () {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
         score1 =  BallScript.playerScore1;
         score2 =  BallScript.playerScore2;


        score.text = score2 + "x" + score1;

        if (score1 == 3)
        {
            score.text = "Player 1 Wins This Match";
            levelManager.LoadNewScene("Level2");
        }
        else if (score2 == 3)
        {
            score.text = "Player 2 Wins This Match";
            levelManager.LoadNewScene("Level2");


        }


    }


}
