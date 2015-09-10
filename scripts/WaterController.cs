using UnityEngine;
using System.Collections;

public class WaterController : MonoBehaviour {
	
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
		
		}
	}


	void OnTriggerEnter2D(Collider2D other) {
		Destroy (this.gameObject);
	}
}
