using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

   
    public float topBound = 4.5f;
    public float bottomBound = -4.5f;
    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {


        float mousePosInUnits = (Input.mousePosition.y / Screen.height*4f)-5;

        Vector3 newPaddlePos = new Vector3(this.transform.position.x,mousePosInUnits, 
                                this.transform.position.z);

        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, bottomBound, topBound);


        this.transform.position = newPaddlePos;
		
	}
}
