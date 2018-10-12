using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Kryz.CharacterStats.Examples;

public class ThrowArrow : MonoBehaviour 
{
	public Inventory inventory;
	public GameObject arrowPrefab;
    public float throwSpeed = 20f;
	
	void Update () 
    {
        if(Input.GetButtonDown("Fire1") && inventory.items.Count > 0)
        {
            transform.LookAt(Vector3.zero);
			
            GameObject arrow = (GameObject) Instantiate(arrowPrefab, transform.position, transform.rotation);
            
			arrow.GetComponent<Rigidbody>().AddForce(transform.forward * throwSpeed,ForceMode.Impulse);
        }
	}
	
	
	
}
