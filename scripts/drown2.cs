using UnityEngine;
using System.Collections;

public class drown2 : MonoBehaviour {
	Health2 myHealth2;
	public float drowntime = 7;
	public float drowntic = 1.5f;
	public int drowndamage;
	// Use this for initialization
	void Start () {
		myHealth2 = GetComponent<Health2>();
		drowndamage = Random.Range (5, 20);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 213) {
			drowntime -= Time.deltaTime;
			drowntic -= Time.deltaTime;
			if(drowntime <= 0 && drowntic <= 0){
				myHealth2.currentHealth2 -= drowndamage;
				drowntic = 1.5f;
				
			}
			
		}
		if (transform.position.y > 213) {
			drowntime = 7;		
		}
		
	}
}
