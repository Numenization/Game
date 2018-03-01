using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	/* 
	Allow the user to have a primary weapon and a secondary weapon
	The user will be able to swap between these weapons with a bindable key

	The user will also have a backpack that can store up to 12 weapons
	*/

	public List<Item> items = new List<Item>();
	public int capacity = 12;

	public bool AddItem(Item item) {
		if(item != null) {
			if(items.Count < capacity) {
				items.Add(item);
				return true;
			}
			else {
				Debug.Log("Inventory is full, cannot add item.");
			}
		}
		else {
			Debug.Log("Trying to add item to inventory, but item is null.");
		}
		return false;
	}

	public void RemoveItem(Item item) {
		if(item != null) {
			items.Remove(item);
		}
	}
}
