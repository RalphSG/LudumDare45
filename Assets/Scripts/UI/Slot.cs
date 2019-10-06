using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {

	private Inventory inventory;
	//private Crafting crafting;
	public int i;

	private void Start()
	{
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
		//crafting = GameObject.FindGameObjectWithTag("Player").GetComponent<Crafting>();
	}

	private void Update()
	{
		if (transform.childCount <= 0)
		{
			inventory.isFull[i] = false;
			//crafting.isFull[i] = false;
		}
	}

	public void DropItem() {
		foreach (Transform child in transform)
		{
			GameObject.Destroy(child.gameObject);
		}
	}
}
