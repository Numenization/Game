using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCard : MonoBehaviour {

	public Item item;
	public Text nameText;
	public Text descText;
	public Image displayImage;

	void Start() {
		nameText.text = item.itemName;
		descText.text = item.description;
		displayImage.sprite = item.sprite;
	}
}
