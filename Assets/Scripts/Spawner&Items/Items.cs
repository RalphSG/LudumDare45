using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

	//Gamemanager
	private GameManager manager;

	private PlayerBehavior player;

	private AudioClip sound;

	//Inventory management variables
	private Inventory inventory;
	public GameObject itemButton;

	//sinking parameter
	private float timeSinked;
	public bool itemNear = false;

	//DiagoVector
	Vector2 wd = new Vector2(-0.5f, -0.5f);
	Vector2 wa = new Vector2(0.5f, -0.5f);
	Vector2 sa = new Vector2(0.5f, 0.5f);
	Vector2 sd = new Vector2(-0.5f, 0.5f);

	float speed = 0f;

	void Start()
	{
		sound = gameObject.GetComponent<AudioSource>().clip;
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehavior>();
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
		manager = GameObject.FindObjectOfType<GameManager>();
		//setting the time until the item sinks to a random time between 10 and 20
		int randTime = Random.Range(10, 20);
		timeSinked = randTime;
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag("NearPerimeter"))
		{
			itemNear = true;
		} else {
			itemNear = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					AudioSource.PlayClipAtPoint(sound, gameObject.transform.position);
					//item can be added to inventory!
					inventory.isFull[i] = true;
					Instantiate(itemButton, inventory.slots[i].transform, false);
					Destroy(gameObject);
					break;
				}
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("FloatingPerimeter"))
		{
			Destroy(gameObject);
		}
	}

	private void Update()
	{
		speed = player.maxSpeed;

		if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
		{
			transform.Translate(wd*speed*Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
		{
			transform.Translate(wa * speed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
		{
			transform.Translate(sa * speed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
		{
			transform.Translate(sd * speed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector2.down * speed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector2.right * speed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector2.up * speed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector2.left * speed * Time.deltaTime);
		}

		if(timeSinked <= 0 && itemNear == false)
		{
			Destroy(gameObject);
		}
		else {
			timeSinked -= Time.deltaTime;
		}
	}
}
