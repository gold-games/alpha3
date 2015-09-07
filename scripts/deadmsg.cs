using UnityEngine;
using System.Collections;

public class deadmsg : MonoBehaviour {

	// Use this for initialization
/*	void Start () {
	
	}
	*/
	// Update is called once per frame
	void Update () {
	//Debug.Log ("message");
	}
	void onGui(){
		GUI.Label(new Rect(100, 100, 100, 500), "You died");
	
	}
}
