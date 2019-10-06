using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

	//Variables for movement
	float direction = 0;
	public float maxSpeed = 5f;

	//Variables for health management
	public float hunger = 0f;
	public float thirst = 0f;
	public float temperature = 0f;

	public Sprite[] characterSprite;

	//Variable for Animator
	private Animator playerAnim;

	//Gamanager access
	private GameManager manager;

	// Use this for initialization
	void Start()
	{
		playerAnim = GetComponent<Animator>();
		manager = GameObject.FindObjectOfType<GameManager>();
		manager.speed = maxSpeed;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
		{
			this.GetComponent<SpriteRenderer>().sprite = characterSprite[0];
			//turn the trail sprite at x degree
			playerAnim.SetBool("isSwimmingLR", false);
			playerAnim.SetBool("isSwimmingFB", true);

		}
		else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
		{
			this.GetComponent<SpriteRenderer>().sprite = characterSprite[0];
			//turn the trail sprite at x degree
			playerAnim.SetBool("isSwimmingLR", false);
			playerAnim.SetBool("isSwimmingFB", true);
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
		{
			this.GetComponent<SpriteRenderer>().sprite = characterSprite[1];
			//turn the trail sprite at x degree
			playerAnim.SetBool("isSwimmingLR", false);
			playerAnim.SetBool("isSwimmingFB", true);
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
		{
			this.GetComponent<SpriteRenderer>().sprite = characterSprite[1];
			//turn the trail sprite at x degree
			playerAnim.SetBool("isSwimmingLR", false);
			playerAnim.SetBool("isSwimmingFB", true);
		}
		else if (Input.GetKey(KeyCode.W))
		{
			this.GetComponent<SpriteRenderer>().sprite = characterSprite[0];
			//turn the trail sprite at x degree
			playerAnim.SetBool("isSwimmingLR", false);
			playerAnim.SetBool("isSwimmingFB", true);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			this.GetComponent<SpriteRenderer>().sprite = characterSprite[2];
			//turn the trail sprite at x degree
			playerAnim.SetBool("isSwimmingFB", false);
			playerAnim.SetBool("isSwimmingLR", true);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			this.GetComponent<SpriteRenderer>().sprite = characterSprite[1];
			//turn the trail sprite at x degree
			playerAnim.SetBool("isSwimmingLR", false);
			playerAnim.SetBool("isSwimmingFB", true);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			this.GetComponent<SpriteRenderer>().sprite = characterSprite[3];
			//turn the trail sprite at x degree
			playerAnim.SetBool("isSwimmingFB", false);
			playerAnim.SetBool("isSwimmingLR", true);
		}
		else {
			playerAnim.SetBool("isSwimmingFB", false);
			playerAnim.SetBool("isSwimmingLR", false);
		}
	}
}
