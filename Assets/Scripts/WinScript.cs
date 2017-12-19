using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour {

    public Text win;
    int playerTotal1 = ScoreScript.score1 + ScoreScript2.score1 + ScoreScript3.score1;
    int playerTotal2 = ScoreScript.score2 + ScoreScript2.score2 + ScoreScript3.score2;

    // Use this for initialization
    void Start()
    {

        if (playerTotal1 > playerTotal2)
        {
            win.text = "Player 1 Wins!" +
                "With a total of " + playerTotal1 + "goals!";
          
        }
        else
        {
            win.text = "Well done!"; win.text = "Player 2 Wins!" +
                "\nWith a total of " + playerTotal2 + " goals!";
           
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
