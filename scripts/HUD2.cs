using UnityEngine;
using System.Collections;

public class HUD2 : MonoBehaviour {

	Health2 myHealth2;
	
	void Awake()
	{
		myHealth2 = GetComponent<Health2>();
	}
	
	void OnGUI()
	{
		if (myHealth2.currentHealth2 <= 0) {
						GUI.Label (new Rect ((Screen.width / 2) - 60, (Screen.height *0.75f) - 10, 120, 20), "You died");
				}		GUI.Label (new Rect (5, (Screen.height*0.50f)+10, 120, 20), "Health: " + myHealth2.currentHealth2 + "/" + myHealth2.maxHealth2);
				
	}
} 