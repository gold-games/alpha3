using UnityEngine;
using System.Collections;

public class deathcounterplayer2 : MonoBehaviour {
	public GameObject player2;
	float deathtimeout = 0;

	
	int deathCounter;
	void Start(){
		
	}
	void FixedUpdate(){
		deathtimeout -= Time.deltaTime;
		Health2 eh = (Health2)player2.GetComponent("Health2");
		
		
		if(eh.currentHealth2 <= 0 && deathtimeout <= 0){
			deathCounter++;
				Debug.Log("deaths:" + deathCounter);
			deathtimeout = 8.0f;
		}
	}
	
	void OnGUI(){
		//Draws out a box on position x and y, with a specified width and height and width.
	GUI.Label(new Rect(5, (Screen.height*0.50f)+25, 120, 20),"Deaths:" + deathCounter);
	}
}
