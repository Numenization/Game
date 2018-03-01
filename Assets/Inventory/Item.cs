using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	public string itemName;
	public string description;
	public double baseValue;
	public double pickupRadius;
	public Sprite sprite;
	public GameObject itemCard;

	public void InRadius() {
		// this is called when the player walks near the item
	}

	public void LeaveRadius() {
		// this is called when the player walks away from the item
	}

	public void PickUp(Inventory inventory) {
		// this is called when the player uses the interact key near the item
	}

	public void Move(Transform transform, Vector2 offset) {

	}
}
