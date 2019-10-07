using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerRegen : MonoBehaviour {

	private PlayerBehavior playerB;

	public void ConsumeFood()
	{
		playerB = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehavior>();
		if (gameObject.tag == "Food")
		{
			playerB.hunger += 10;
		}
		else if (gameObject.tag == "Fish")
		{
			playerB.hunger += 20;
		}
		Destroy(gameObject);
	}
}