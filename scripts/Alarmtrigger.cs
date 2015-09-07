using UnityEngine;
using System.Collections;

public class Alarmtrigger : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider sphere){
		GetComponent<AudioSource>().Play ();
		GetComponent<Animation>().Play ();
	}
void OnTriggerExit (Collider sphere){
		GetComponent<AudioSource>().Stop ();
		GetComponent<Animation>().Stop ();
	}
}
