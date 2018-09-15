using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Kryz.CharacterStats.Examples
{
	[RequireComponent(typeof(InteractableArea))]
	public class PickUpObject : MonoBehaviour 
	{
		InteractableArea interactable;
		//public GameObject inventoryPanel;

		public EquippableItem eItem;
		public Inventory inventory;

		void Start ()
		{
			interactable = GetComponent<InteractableArea> ();
		}

		void Update () 
		{
			if (interactable.isInsideArea && Input.GetKeyDown (KeyCode.E)) 
			{
				PickUp ();
				Destroy (this.gameObject);
			}
		}

		void PickUp()
		{
			GameObject item = new GameObject ();
			
			inventory.AddItem(eItem);
		}
		
	}
}
