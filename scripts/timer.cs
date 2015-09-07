using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {
	public GameObject target;
	public static float time; 
	public static bool timeStarted = true;
	public bool posted = false;
	int minutes;
	int seconds;
	string niceTime;
	int kinghealth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (timeStarted == true) {
			time += Time.deltaTime;
		}  
		winstate eh = (winstate)target.GetComponent ("winstate");

		if (eh.curHealth <= 0 && posted == false) {
			Debug.Log("highscore!!");
			Debug.Log (Mathf.CeilToInt(time));
			HighScoreManager._instance.SaveHighScore("test", Mathf.CeilToInt(time));
			posted = true;
		}
	}
	
	
	void OnGUI() {
		minutes = Mathf.FloorToInt(time / 60F);
		seconds = Mathf.FloorToInt(time - minutes * 60);
		
		niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);
		
		GUI.Label(new Rect(10,10,250,100), niceTime);
	}
}

