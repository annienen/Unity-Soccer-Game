using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public static int playerScore1=0;
    public static int playerScore2=0;

    bool gameStart = false;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetMouseButtonDown(0) && !gameStart)
        {
            gameStart = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
    }

   

    public void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.name == "RightScoreBorder")
        {
            gameStart = false;
            this.GetComponent<Rigidbody2D>().transform.position = new Vector3(0, 0, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            playerScore2 += 1;
        }
        else if (col.gameObject.name == "LeftScoreBorder")
        {
            gameStart = false;
            this.GetComponent<Rigidbody2D>().transform.position = new Vector3(0, 0, 0);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            playerScore1 += 1;


        }
        

    }
}
