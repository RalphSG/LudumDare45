using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingValidation : MonoBehaviour {
	
	private int clothNb;
	private int plankNb;
	private int ropeNb;
	private int seaweedNb;
	private int stickNb;
	private int tarpaulinNb;
	private int metalNb;
	private int sumItems;
	private string nameTag;

	public GameObject[] item;

	private Crafting crafting;
	private Inventory inventory;
	private GameObject previsu;

	public void CheckCraftable () {
		//reset the numbers
		clothNb = 0;
		plankNb = 0;
		ropeNb = 0;
		seaweedNb = 0;
		stickNb = 0;
		tarpaulinNb = 0;
		metalNb = 0;
		previsu = GameObject.FindGameObjectWithTag("Previsu");
		Destroy(previsu);
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
					Instantiate(Resources.Load("Previsu_SeaweedWig"), inventory.slots[i].transform, false);
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
					Instantiate(Resources.Load("Previsu_Poncho"), inventory.slots[i].transform, false);
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
					Instantiate(Resources.Load("Previsu_Hat"), inventory.slots[i].transform, false);
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
					Instantiate(Resources.Load("Previsu_PonchoPermeable"), inventory.slots[i].transform, false);
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
					Instantiate(Resources.Load("Previsu_HatPermeable"), inventory.slots[i].transform, false);
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
					Instantiate(Resources.Load("Previsu_Spear"), inventory.slots[i].transform, false);
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
					Instantiate(Resources.Load("Previsu_Net"), inventory.slots[i].transform, false);
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
					Instantiate(Resources.Load("Previsu_SurvivalRaft"), inventory.slots[i].transform, false);
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
					Instantiate(Resources.Load("Previsu_PaddleSmall"), inventory.slots[i].transform, false);
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
					Instantiate(Resources.Load("Previsu_SailSmall"), inventory.slots[i].transform, false);
					break;
				}
			}
		}
	}

	public void Craft () {

		//reset the numbers
		clothNb = 0;
		plankNb = 0;
		ropeNb = 0;
		seaweedNb = 0;
		stickNb = 0;
		tarpaulinNb = 0;
		metalNb = 0;
		previsu = GameObject.FindGameObjectWithTag("Previsu");
		Destroy(previsu);
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
		crafting = GameObject.FindGameObjectWithTag("Player").GetComponent<Crafting>();

		//check if something is craftable
		for (int i = 0; i<crafting.slots.Length; i++) {
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

		//craft the item
		if (seaweedNb==3 && sumItems==3) //seaweed wig
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(Resources.Load("SeaweedWigButton"), inventory.slots[i].transform, false);
					break;
				}
			}
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}
		else if (clothNb == 2 && sumItems == 2) //poncho
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(Resources.Load("PonchoButton"), inventory.slots[i].transform, false);
					break;
				}
			}
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}
		else if (clothNb == 1 && sumItems == 1) //hat
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(Resources.Load("HatButton"), inventory.slots[i].transform, false);
					break;
				}
			}
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}
		else if (tarpaulinNb == 1 && ropeNb == 1 && sumItems == 2) //permeable poncho
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(Resources.Load("PonchoPButton"), inventory.slots[i].transform, false);
					break;
				}
			}
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}
		else if (tarpaulinNb == 1 && sumItems == 1) //permeable hat
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(Resources.Load("HatPButton"), inventory.slots[i].transform, false);
					break;
				}
			}
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}
		else if (stickNb == 1 && metalNb == 1 && sumItems == 2) //spear
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(Resources.Load("SpearButton"), inventory.slots[i].transform, false);
					break;
				}
			}
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}
		else if (ropeNb == 2 && sumItems == 2) //net
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(Resources.Load("NetgButton"), inventory.slots[i].transform, false);
					break;
				}
			}
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}
		else if (plankNb == 4 && sumItems == 4) //survival raft
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(Resources.Load("RaftSButton"), inventory.slots[i].transform, false);
					break;
				}
			}
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}
		else if (plankNb == 1 && sumItems == 1) //small paddle
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(Resources.Load("PaddleSButton"), inventory.slots[i].transform, false);
					break;
				}
			}
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}
		else if (tarpaulinNb == 2 && ropeNb == 1 && sumItems == 3) //small sail
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(Resources.Load("SailSButton"), inventory.slots[i].transform, false);
					break;
				}
			}
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}

	}
}
