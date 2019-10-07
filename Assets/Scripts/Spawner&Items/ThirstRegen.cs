using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirstRegen : MonoBehaviour {

	private PlayerBehavior playerB;
	private AudioClip sound;

	public void ConsumeDrink()
	{
		sound = gameObject.GetComponent<AudioSource>().clip;
		AudioSource.PlayClipAtPoint(sound, gameObject.transform.position);
		playerB = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehavior>();
		if (gameObject.tag == "Bottle")
		{
			playerB.thirst += 10;
		}
		//else if (gameObject.tag == "Fish")
		//{
		//	playerB.hunger += 5;
		//}
		Destroy(gameObject);
	}
}
