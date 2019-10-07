using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRaft : MonoBehaviour {

	private PlayerBehavior player;

	public void goOnRaft() {
	player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehavior>();
		player.onRaft = true;
		player.maxSpeed = 2f;
		Destroy(gameObject);
	}

}
