using UnityEngine;
using System.Collections;

public class drown : MonoBehaviour {
	Health myHealth;
	public float drowntime = 7;
	public float drowntic = 1.5f;
	public int drowndamage;
	// Use this for initialization
	void Start () {
		myHealth = GetComponent<Health>();
		drowndamage = Random.Range (5, 20);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 213) {
			drowntime -= Time.deltaTime;
			drowntic -= Time.deltaTime;
			if(drowntime <= 0 && drowntic <= 0){
				myHealth.currentHealth -= drowndamage;
				drowntic = 1.5f;

			}

		}
		if (transform.position.y > 213) {
			drowntime = 7;		
		}

	}
}
