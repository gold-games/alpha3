using UnityEngine;
using System.Collections;

public class Attack2 : MonoBehaviour {
	public GameObject player1;
	public float attackTimer;

	// Use this for initialization
	void Start () {
		attackTimer = 0;
	}
	void Update (){
		if(Input.GetKeyDown("m")) {
			if(attackTimer == 0) {
				Attack();
				
			}
		}
		
	}
	
	private void Attack() {
		float distance = Vector3.Distance(player1.transform.position, transform.position);
		
		Vector3 dir = (player1.transform.position - transform.position).normalized;
		
		float direction = Vector3.Dot(dir, transform.forward);
		
		if(distance < 6f) {
			if(direction > 0) {
				Health eh = (Health)player1.GetComponent("Health");
				eh.ModifyHealth(-5);
			}
		}
	}
}


