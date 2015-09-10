using UnityEngine;
using System.Collections;

public class firehealth : MonoBehaviour {

	public GameObject enWat;

	int fHealth = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
	if (fHealth <= 0) {
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
	if (other.gameObject.CompareTag ("waten") == true) {
			fHealth -= 25;
		}
	}
}
