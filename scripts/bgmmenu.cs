using UnityEngine;
using System.Collections;

public class bgmmenu : MonoBehaviour {
	public AudioClip EpicOrchestral;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	if (!GetComponent<AudioSource>().isPlaying) {
			GetComponent<AudioSource>().loop = true; GetComponent<AudioSource>().clip = EpicOrchestral; GetComponent<AudioSource>().Play();
		}
	}
}
