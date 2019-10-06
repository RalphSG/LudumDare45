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
	public string nameTag;

	private Crafting crafting;

	public void CheckCraftable () {
		//reset the numbers
		clothNb = 0;
		plankNb = 0;
		ropeNb = 0;
		seaweedNb = 0;
		stickNb = 0;
		tarpaulinNb = 0;

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
				//crafting.isFull[i] = false;
				//Destroy(crafting.slots[i].transform.GetChild(0).gameObject);
			}
		}
		Debug.Log(clothNb);
		Debug.Log(plankNb);
		Debug.Log(ropeNb);
		Debug.Log(seaweedNb);
		Debug.Log(stickNb);
		Debug.Log(tarpaulinNb);
	}
}
