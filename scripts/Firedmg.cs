using UnityEngine;
using System.Collections;

public class Firedmg : MonoBehaviour
{
	public GameObject player1;
		Health myHealth;
		public float burntic = 1.5f;
		public int burndamage;

		// Use this for initialization
		void Start ()
		{

		myHealth = player1.GetComponent<Health>();
		burndamage = Random.Range (5, 20);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnTriggerStay (Collider other)
		{
		Debug.Log("triggered");
		if (other.gameObject.CompareTag("Player") == true);
				{
			Debug.Log("triggered player");
						burntic -= Time.deltaTime;

			if (burntic <= 0 && other.gameObject.CompareTag("Player") == true) {
				Health eh = (Health)player1.GetComponent("Health");
				eh.ModifyHealth(burndamage*-1);
								burntic = 1.5f;
				Debug.Log("triggered burn");
						}
				}

		}

}
