using UnityEngine;
using System.Collections;

public class Firedmg : MonoBehaviour
{
	public GameObject player1;
		Health myHealth;
		public int burndamage;

		// Use this for initialization
		void Start ()
		{

		myHealth = player1.GetComponent<Health>();
		burndamage = 1;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

	void OnCollisionStay2D(Collision2D other) {

		Debug.Log("triggered");
		if (other.gameObject.CompareTag("Player") == true);
				{
			Debug.Log("triggered player");

			if (other.gameObject.CompareTag("Player") == true) {
				Health eh = (Health)player1.GetComponent("Health");
				eh.ModifyHealth(burndamage*-1);
				Debug.Log("triggered burn");
						}
				}

		}

}
