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
		transform.rotation *= Quaternion.Euler(0, 0, 180);
		if (craftingPanel)
		{
			for (int i = 0; i < crafting.slots.Length; i++)
			{
				if (crafting.isFull[i] == true)
				{
					item[i] = crafting.slots[i].transform.GetChild(0).gameObject;
					crafting.isFull[i] = false;
					//Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
				}
			}
			for (int i = 0; i < inventory.slots.Length; i++)
			{

				//item can be added to inventory!
				for (int y = 0; y < item.Length; y++)
				{
					if (inventory.isFull[y] == false)
					{
						inventory.isFull[y] = true;
						Instantiate(item[i], inventory.slots[y].transform, false);
						Destroy(item[i]);
						break;
					}
				}
				Destroy(item[i]);
			}
			craftingPanel = false;
		}
		else {
			craftingPanel = true;
		}
	}
}
