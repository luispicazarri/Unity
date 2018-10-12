using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Kryz.CharacterStats.Examples
{
	public class PickUpAndroidObject : MonoBehaviour 
	{
		//public GameObject inventoryPanel;

		public EquippableItem eItem;
		public Inventory inventory;


		void OnMouseDown () 
		{
		
			PickUp ();
			Destroy (this.gameObject);

		}

		void PickUp()
		{			
			inventory.AddItem(eItem);
		}
		
	}
}
