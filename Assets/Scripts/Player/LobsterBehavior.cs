using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobsterBehavior : MonoBehaviour {

	//Variables for movement
	float direction = 0;
	public float maxSpeed = 5f;

	//Variables for health management
	public float hunger = 0f;
	public float thirst = 0f;
	public float temperature = 0f;

	//Variable for Animator
	private Animator playerAnim;

	//Gamanager access
	private GameManager manager;

	// Use this for initialization
	void Start () {
		playerAnim = GetComponent<Animator>();
		manager = GameObject.FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
		{
			transform.rotation = Quaternion.AngleAxis(315, Vector3.forward);
			playerAnim.SetBool("isSwimming", true);
		}
		else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
		{
			transform.rotation = Quaternion.AngleAxis(45, Vector3.forward);
			playerAnim.SetBool("isSwimming", true);
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
		{
			transform.rotation = Quaternion.AngleAxis(135, Vector3.forward);
			playerAnim.SetBool("isSwimming", true);
		}
		else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
		{
			transform.rotation = Quaternion.AngleAxis(225, Vector3.forward);
			playerAnim.SetBool("isSwimming", true);
		}
		else if (Input.GetKey(KeyCode.W))
		{
			transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
			playerAnim.SetBool("isSwimming", true);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
			playerAnim.SetBool("isSwimming", true);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
			playerAnim.SetBool("isSwimming", true);
		}
		else if (Input.GetKey(KeyCode.D)){
			transform.rotation = Quaternion.AngleAxis(270, Vector3.forward);
			playerAnim.SetBool("isSwimming", true);
		}
		else {
			playerAnim.SetBool("isSwimming", false);
		}
	}
}
