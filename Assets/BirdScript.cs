using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour {

	public Rigidbody2D myRB;
	public float birdStrength = 18;
    public LogicManagerScript logic;
	public bool birdIsAlive = true;

    void Start () {
		logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
		{
            myRB.velocity = Vector2.up * birdStrength;
        }
		if (gameObject.transform.position.y < -500)
		{
            Vector3 newPosition = gameObject.transform.position;
            newPosition.y = 10;
            gameObject.transform.position = newPosition;
		}
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "wall")
        	{
            	// If it's a wall, do nothing and return early
            	return;
       	 	}
		logic.gameOver();
		birdIsAlive = false;
	}
}
