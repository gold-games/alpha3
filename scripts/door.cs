using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	
	public GameObject player1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionStay2D(Collision2D other) {
			if (other.gameObject.CompareTag("Player") == true);
			{
				if (Input.GetKeyDown(KeyCode.E)) {
				this.GetComponent<Collider2D>().isTrigger = true;
				}
			}
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player") == true) {
			if(Input.GetKeyDown(KeyCode.E)) {
				this.GetComponent<Collider2D>().isTrigger = false;
			}
		}
	}

}
