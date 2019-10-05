using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] item;
	private float timeBtwSpawn;

	private void Start()
	{
		int randTime = Random.Range(0, 10);
		timeBtwSpawn = randTime;
	}

	private void Update()
	{
		if (timeBtwSpawn <= 0)
		{
			int rand = Random.Range(0, item.Length);
			Instantiate(item[rand], transform.position, Quaternion.identity);
			int randTime = Random.Range(2, 4);
			timeBtwSpawn = randTime;
		}
		else {
			timeBtwSpawn -= Time.deltaTime;
		}
	}
}
