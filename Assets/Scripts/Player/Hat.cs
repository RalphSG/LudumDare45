using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hat : MonoBehaviour {

	private int headProtec;
	private PlayerBehavior player;
	public Sprite[] hatSprites;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehavior>();
	}

	// Update is called once per frame
	void Update()
	{
		headProtec = player.headProtec;
		if (headProtec == 0)
		{
			this.GetComponent<SpriteRenderer>().enabled = false;
		}
		else if (headProtec == 1)
		{
			this.GetComponent<SpriteRenderer>().enabled = true;
			if (this.GetComponent<SpriteRenderer>().sprite != hatSprites[0] && ((Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S))))
			{
				this.GetComponent<SpriteRenderer>().sprite = hatSprites[0];
			}
			else if (this.GetComponent<SpriteRenderer>().sprite != hatSprites[1] && ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D))))
			{
				this.GetComponent<SpriteRenderer>().sprite = hatSprites[1];
			}
		}
		else if (headProtec == 2)
		{
			this.GetComponent<SpriteRenderer>().enabled = true;
			if (this.GetComponent<SpriteRenderer>().sprite != hatSprites[2] && ((Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.S))))
			{
				this.GetComponent<SpriteRenderer>().sprite = hatSprites[2];
			}
			else if (this.GetComponent<SpriteRenderer>().sprite != hatSprites[3] && ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D))))
			{
				this.GetComponent<SpriteRenderer>().sprite = hatSprites[3];
			}
		}
	}
}

