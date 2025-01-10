using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	public GameObject Pipe;
	public float spawnRate = 3;
	private float timer = 0;
	public float hightOffSet = 10;

	// Use this for initialization
	void Start () {
        spawnPipe();
    }

    // Update is called once per frame
    void Update () {
		if (timer < spawnRate)
		{
			timer += Time.deltaTime;
		}
		else
		{
			spawnPipe();
			timer = 0;
		}	
	}
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - hightOffSet;
        float highestPoint = transform.position.y + hightOffSet;

        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
