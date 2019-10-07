using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingValidation : MonoBehaviour {
	
	public int clothNb;
	public int plankNb;
	public int ropeNb;
	public int seaweedNb;
	public int stickNb;
	public int tarpaulinNb;
	public int metalNb;
	public int sumItems;
	public string nameTag;

	public GameObject[] previsu;

	private Crafting crafting;
	private Inventory inventory;

	public void CheckCraftable () {
		//reset the numbers
		clothNb = 0;
		plankNb = 0;
		ropeNb = 0;
		seaweedNb = 0;
		stickNb = 0;
		tarpaulinNb = 0;
		metalNb = 0;

		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
		crafting = GameObject.FindGameObjectWithTag("Player").GetComponent<Crafting>();

		//check if something is craftable
		for (int i = 0; i < crafting.slots.Length; i++) {
			if (crafting.isFull[i] == true) {
				nameTag = crafting.slots[i].transform.GetChild(0).gameObject.tag;
				Debug.Log(nameTag);
				//increment the numbers of items
				if (nameTag == "Cloth") {
					clothNb = clothNb + 1;
				}
				else if (nameTag == "Plank") {
					plankNb = plankNb + 1;
				}
				else if (nameTag == "Rope") {
					ropeNb= ropeNb + 1;
				}
				else if (nameTag == "Seaweed") {
					seaweedNb = seaweedNb + 1;
				}
				else if (nameTag == "Stick") {
					stickNb = stickNb + 1;
				}
				else if (nameTag == "Tarpaulin") {
					tarpaulinNb = tarpaulinNb + 1;
				}
				else if (nameTag == "Scrap")
				{
					metalNb = metalNb + 1;
				}
			}
		}
		//to have exact recipes, count how many items in total
		sumItems = clothNb + plankNb + ropeNb + seaweedNb + stickNb + tarpaulinNb + metalNb;

		//compare available resources with recipes
		if (seaweedNb==3 && sumItems==3) //seaweed wig
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					Instantiate(previsu[0], inventory.slots[i].transform, false);
					break;
				}
			}
		}
		else if (clothNb == 2 && sumItems == 2) //poncho
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					Instantiate(previsu[1], inventory.slots[i].transform, false);
					break;
				}
			}
		}
		else if (clothNb == 1 && sumItems == 1) //hat
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					Instantiate(previsu[2], inventory.slots[i].transform, false);
					break;
				}
			}
		}
		else if (tarpaulinNb == 1 && ropeNb == 1 && sumItems == 2) //permeable poncho
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					Instantiate(previsu[3], inventory.slots[i].transform, false);
					break;
				}
			}
		}
		else if (tarpaulinNb == 1 && sumItems == 1) //permeable hat
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					Instantiate(previsu[4], inventory.slots[i].transform, false);
					break;
				}
			}
		}
		else if (stickNb == 1 && metalNb == 1 && sumItems == 2) //spear
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					Instantiate(previsu[5], inventory.slots[i].transform, false);
					break;
				}
			}
		}
		else if (ropeNb == 2 && sumItems == 2) //net
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					Instantiate(previsu[6], inventory.slots[i].transform, false);
					break;
				}
			}
		}
		else if (plankNb == 4 && sumItems == 4) //survival raft
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					Instantiate(previsu[7], inventory.slots[i].transform, false);
					break;
				}
			}
		}
		else if (plankNb == 1 && sumItems == 1) //small paddle
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					Instantiate(previsu[8], inventory.slots[i].transform, false);
					break;
				}
			}
		}
		else if (tarpaulinNb == 2 && ropeNb == 1 && sumItems == 3) //small sail
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					Instantiate(previsu[9], inventory.slots[i].transform, false);
					break;
				}
			}
		}
	}
}
