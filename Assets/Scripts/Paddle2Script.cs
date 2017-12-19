using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2Script : MonoBehaviour {
    public float speed = 30;
    public string axis = "Vertical";
    public float topBound = 4.5F;
    public float bottomBound = -3.5F;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;

        if (transform.position.y > topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound, 0);
        }
        else if (transform.position.y < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, bottomBound, 0);
        }
    }
}

