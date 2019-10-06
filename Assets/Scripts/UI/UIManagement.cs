using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagement : MonoBehaviour {

	public GameObject craftingPanel;
	private bool craftingPanelIsOpen = false;

	public void OpenCraftingMenu()
	{
		if (craftingPanelIsOpen)
		{
			craftingPanelIsOpen = false;
		}
		else {
			craftingPanelIsOpen = true;
		}
		craftingPanel.SetActive(craftingPanelIsOpen);
	}
}
