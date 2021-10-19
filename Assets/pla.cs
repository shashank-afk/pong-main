using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pla : MonoBehaviour {

    public float moveHorizontal; 
    public float moveVertical;
    public float speed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        moveHorizontal = Input.GetAxis("Horizontal") + speed;
        moveVertical = Input.GetAxis("Vertical") + speed;

        transform.Translate(moveHorizontal, moveVertical, 0);

	}
}