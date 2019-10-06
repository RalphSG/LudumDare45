using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSlot : MonoBehaviour {

	//private Inventory inventory;
	private Crafting crafting;
	public int i;

	private void Start()
	{
		crafting = GameObject.FindGameObjectWithTag("Player").GetComponent<Crafting>();
	}

	private void Update()
	{
		if (transform.childCount <= 0)
		{
			crafting.isFull[i] = false;
		}
	}
}
