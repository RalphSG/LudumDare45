using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

	//Gamemanager
	private GameManager manager;

	//DiagoVector
	Vector2 wd = new Vector2(-0.5f, -0.5f);
	Vector2 wa = new Vector2(0.5f, -0.5f);
	Vector2 sa = new Vector2(0.5f, 0.5f);
	Vector2 sd = new Vector2(-0.5f, 0.5f);

	float speed = 0f;

	void Start()
	{
		manager = GameObject.FindObjectOfType<GameManager>();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			Destroy(gameObject);
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
		speed = manager.speed;

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
	}
}
