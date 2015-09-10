using UnityEngine;
using System.Collections;

public class GmScript : MonoBehaviour {

	public float gameTime = 300f;

	public int gone = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (gameTime > 0) {
			gameTime -= Time.deltaTime;
		}
		if (gameTime <= 0) {
			Debug.Log("Game end");
			if(gone == 1){
				Application.LoadLevel("gameover");
			}
		}

	}
}
