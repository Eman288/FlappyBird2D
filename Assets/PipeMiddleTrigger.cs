using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleTrigger : MonoBehaviour {

	public LogicManagerScript logic;
	// Use this for initialization
	void Start () {
		logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.layer == 8)
		{ 
			logic.addScore(1);
		}
	}
}
