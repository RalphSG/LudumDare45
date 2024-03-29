﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour {

	//stats
	public float health;
	public float hunger;
	public float thirst;
	public float hungerSpeed = 0.1f;
	public float thirstSpeed = 0.1f;
	public int headProtec;
	public int bodyProtec;

	//UI control
	public Slider healthBar;
	public Slider hungerBar;
	public Slider thirstBar;
	public GameObject deathPanel;

	//Variables for movement
	float direction = 0;
	public float maxSpeed;
	public bool onRaft;

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
		maxSpeed = 1f;
		healthBar.value = health;
		hungerBar.value = hunger;
		thirstBar.value = thirst;
		headProtec = 0;
		bodyProtec = 0;
	}

	// Update is called once per frame
	void Update()
	{
		if (onRaft == false)
		{
			if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
			{
				this.GetComponent<SpriteRenderer>().sprite = characterSprite[0];
				//turn the trail sprite at x degree
				playerAnim.SetBool("isSwimmingLR", false);
				playerAnim.SetBool("isSwimmingFB", true);

				hungerSpeed = 0.2f;
				thirstSpeed = 0.2f;
			}
			else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
			{
				this.GetComponent<SpriteRenderer>().sprite = characterSprite[0];
				//turn the trail sprite at x degree
				playerAnim.SetBool("isSwimmingLR", false);
				playerAnim.SetBool("isSwimmingFB", true);

				hungerSpeed = 0.2f;
				thirstSpeed = 0.2f;
			}
			else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
			{
				this.GetComponent<SpriteRenderer>().sprite = characterSprite[1];
				//turn the trail sprite at x degree
				playerAnim.SetBool("isSwimmingLR", false);
				playerAnim.SetBool("isSwimmingFB", true);

				hungerSpeed = 0.2f;
				thirstSpeed = 0.2f;
			}
			else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
			{
				this.GetComponent<SpriteRenderer>().sprite = characterSprite[1];
				//turn the trail sprite at x degree
				playerAnim.SetBool("isSwimmingLR", false);
				playerAnim.SetBool("isSwimmingFB", true);

				hungerSpeed = 0.2f;
				thirstSpeed = 0.2f;
			}
			else if (Input.GetKey(KeyCode.W))
			{
				this.GetComponent<SpriteRenderer>().sprite = characterSprite[0];
				//turn the trail sprite at x degree
				playerAnim.SetBool("isSwimmingLR", false);
				playerAnim.SetBool("isSwimmingFB", true);

				hungerSpeed = 0.2f;
				thirstSpeed = 0.2f;
			}
			else if (Input.GetKey(KeyCode.A))
			{
				this.GetComponent<SpriteRenderer>().sprite = characterSprite[2];
				//turn the trail sprite at x degree
				playerAnim.SetBool("isSwimmingFB", false);
				playerAnim.SetBool("isSwimmingLR", true);

				hungerSpeed = 0.2f;
				thirstSpeed = 0.2f;
			}
			else if (Input.GetKey(KeyCode.S))
			{
				this.GetComponent<SpriteRenderer>().sprite = characterSprite[1];
				//turn the trail sprite at x degree
				playerAnim.SetBool("isSwimmingLR", false);
				playerAnim.SetBool("isSwimmingFB", true);

				hungerSpeed = 0.2f;
				thirstSpeed = 0.2f;
			}
			else if (Input.GetKey(KeyCode.D))
			{
				this.GetComponent<SpriteRenderer>().sprite = characterSprite[3];
				//turn the trail sprite at x degree
				playerAnim.SetBool("isSwimmingFB", false);
				playerAnim.SetBool("isSwimmingLR", true);

				hungerSpeed = 0.2f;
				thirstSpeed = 0.2f;
			}
			else {
				playerAnim.SetBool("isSwimmingFB", false);
				playerAnim.SetBool("isSwimmingLR", false);

				hungerSpeed = 0.2f;
				thirstSpeed = 0.2f;
			}
		}
		else if (onRaft == true)
		{
			this.GetComponent<SpriteRenderer>().sprite = characterSprite[4];
			if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
			{
				transform.rotation *= Quaternion.Euler(0, 0, 315);
			}
			else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
			{
				transform.rotation *= Quaternion.Euler(0, 0, 45);
			}
			else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
			{
				transform.rotation *= Quaternion.Euler(0, 0, 135);
			}
			else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
			{
				transform.rotation *= Quaternion.Euler(0, 0, 225);
			}
			else if (Input.GetKey(KeyCode.W))
			{
				transform.rotation *= Quaternion.Euler(0, 0, 0);
			}
			else if (Input.GetKey(KeyCode.A))
			{
				transform.rotation *= Quaternion.Euler(0, 0, 90);
			}
			else if (Input.GetKey(KeyCode.S))
			{
				transform.rotation *= Quaternion.Euler(0, 0, 180);
			}
			else if (Input.GetKey(KeyCode.D))
			{
				transform.rotation *= Quaternion.Euler(0, 0, 270);
			}
		}

		//Update stats and UI values
		if (hunger <= 0)
		{
			hunger = 0;
		}
		else {
			hunger -= Time.deltaTime * hungerSpeed;
		}
		if (thirst <= 0)
		{
			thirst = 0;
		}
		else {
			thirst -= Time.deltaTime * thirstSpeed;
		}
		if (hunger == 0 || thirst == 0)
		{
			health -= Time.deltaTime * 0.5f;
		}

		healthBar.value = health;
		hungerBar.value = hunger;
		thirstBar.value = thirst;

		hungerSpeed = 0.1f;
		thirstSpeed = 0.1f;

		if (health <= 0)
		{
			deathPanel.SetActive(true);
		}
	}
}
