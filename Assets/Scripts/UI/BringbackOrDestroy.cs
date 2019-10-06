using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringbackOrDestroy : MonoBehaviour {
	public GameObject[] item;
	private Crafting crafting;
	private Inventory inventory;
	public bool craftingPanel;
	private void Start()
	{
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
		crafting = GameObject.FindGameObjectWithTag("Player").GetComponent<Crafting>();
		craftingPanel = false;
	}

	public void BbOrD()
	{
		if (craftingPanel)
		{
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				if (crafting.isFull[i] == true)
				{
					item[i] = crafting.slots[i].transform.GetChild(0).gameObject;
					//Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
				}
			}
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					//item can be added to inventory!
					Instantiate(item[i], inventory.slots[i].transform, false);
					Destroy(item[i]);
				}
				else {
					Destroy(item[i]);
				}

			}
			craftingPanel = false;
		}
		else {
			craftingPanel = true;
		}
	}
}
