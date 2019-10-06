using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingComponent : MonoBehaviour {
	private Inventory inventory;
	private Crafting crafting;
	private BringbackOrDestroy craftingButton;
	private bool craftingPanel;
	private void Start()
	{
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
		crafting = GameObject.FindGameObjectWithTag("Player").GetComponent<Crafting>();
		craftingButton = GameObject.FindGameObjectWithTag("CraftingButton").GetComponent<BringbackOrDestroy>();
	}

	public void ChangingSlots()
	{
		
		if (transform.parent.tag == "Slot")
		{
			craftingPanel = craftingButton.craftingPanel;
			if (craftingPanel == true)
			{
				for (int i = 0; i < crafting.slots.Length; i++)
				{
					if (crafting.isFull[i] == false)
					{
						//item can be added to inventory!
						crafting.isFull[i] = true;
						Instantiate(gameObject, crafting.slots[i].transform, false);
						Destroy(gameObject);
						break;
					}
				}
			}
		}
		else if (transform.parent.tag == "CraftingSlot")
		{
				for (int i = 0; i < inventory.slots.Length; i++)
				{
					if (inventory.isFull[i] == false)
					{
						//item can be added to inventory!
						inventory.isFull[i] = true;
						Instantiate(gameObject, inventory.slots[i].transform, false);
						Destroy(gameObject);
						break;
					}
				}
			}
	}
}
