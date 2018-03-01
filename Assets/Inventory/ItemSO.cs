using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Default Item Name", menuName = "Item", order = 1)]
public class ItemSO : ScriptableObject {

	public string itemName;
	public GameObject gameObject;
}
