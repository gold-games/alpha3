using UnityEngine;
using System.Collections;

public class firedmg2 : MonoBehaviour
{
	public GameObject player2;
	Health2 myHealth;
	public float burntic = 1.5f;
	public int burndamage;
	
	// Use this for initialization
	void Start ()
	{
		myHealth = player2.GetComponent<Health2>();
		burndamage = Random.Range (5, 20);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerStay (Collider other2)
	{
		Debug.Log("triggered");
		if (other2.gameObject.CompareTag("Player2") == true)
		{
			Debug.Log(other2.gameObject.CompareTag("Player2"));
			Debug.Log("triggered player2");
			burntic -= Time.deltaTime;
			
			if (burntic <= 0 && other2.gameObject.CompareTag("Player2") == true) {
				Health2 eh = (Health2)player2.GetComponent("Health2");
				eh.ModifyHealth(burndamage*-1);
				burntic = 1.5f;
				Debug.Log("triggered burn");
			}
					}
		
	}
	
}
